using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class Ayarlar : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public Ayarlar()
        {
            InitializeComponent();
        }

        // Kullanıcı doğrulama fonksiyonu
        private bool KullaniciGirisi(string kullaniciAdi, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Sorumlular WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Kullanıcı adı veya şifre değiştiğinde kontrol yap
        private void txt_KullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            OtomatikGirisKontrol();
        }

        private void txt_Sifre_TextChanged(object sender, EventArgs e)
        {
            OtomatikGirisKontrol();
        }

        // Kullanıcı doğrulama kontrolü
        private void OtomatikGirisKontrol()
        {
            // Eğer kullanıcı adı boşsa işlemi yapma
            if (string.IsNullOrWhiteSpace(txt_KullaniciAdi.Text))
            {
                return;
            }

            // Kullanıcı giriş yapabiliyorsa alanları aç
            if (KullaniciGirisi(txt_KullaniciAdi.Text, txt_Sifre.Text))
            {
                txt_YeniSifre.Enabled = true;
                txt_YeniSifreTekrar.Enabled = true;
                txt_OduncSuresi.Enabled = true;
                txt_CezaUcreti.Enabled = true;
                btn_Kaydet.Enabled = true;
            }
            else
            {
                txt_YeniSifre.Enabled = false;
                txt_YeniSifreTekrar.Enabled = false;
                txt_OduncSuresi.Enabled = false;
                txt_CezaUcreti.Enabled = false;
                btn_Kaydet.Enabled = false;
            }
        }

        // Şifre değiştirme fonksiyonu
        private bool SifreDegistir(string kullaniciAdi, string eskiSifre, string yeniSifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Sorumlular SET Sifre = @yeniSifre WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @eskiSifre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@eskiSifre", eskiSifre);
                    cmd.Parameters.AddWithValue("@yeniSifre", yeniSifre);

                    int affectedRows = cmd.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
        }

        // Ödünç süresi ve ceza miktarını kaydetme fonksiyonu
        private bool AyarlariKaydet(int? oduncGun, decimal? gecikmeCezasi)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Ayarlar SET " +
                               (oduncGun.HasValue ? "OduncSuresi = @oduncGun, " : "") +
                               (gecikmeCezasi.HasValue ? "GecikmeCezasi = @gecikmeCezasi, " : "");

                // Eğer hiçbir değişiklik yapılmayacaksa SQL sorgusunu çalıştırma
                if (query.EndsWith(", "))
                {
                    query = query.Substring(0, query.Length - 2); // Son virgülü sil
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (oduncGun.HasValue) cmd.Parameters.AddWithValue("@oduncGun", oduncGun.Value);
                        if (gecikmeCezasi.HasValue) cmd.Parameters.AddWithValue("@gecikmeCezasi", gecikmeCezasi.Value);

                        int affectedRows = cmd.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
                return false;
            }
        }

        // **Kaydet butonu hem şifre değiştiriyor hem de ayarları kaydediyor**
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {   
            bool isUpdated = false;

            // Eğer yeni şifre girilmişse şifreyi değiştir
            if (!string.IsNullOrWhiteSpace(txt_YeniSifre.Text) || !string.IsNullOrWhiteSpace(txt_YeniSifreTekrar.Text))
            {
                if (txt_YeniSifre.Text != txt_YeniSifreTekrar.Text)
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SifreDegistir(txt_KullaniciAdi.Text, txt_Sifre.Text, txt_YeniSifre.Text))
                {
                    MessageBox.Show("Şifre başarıyla değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isUpdated = true;
                }
                else
                {
                    MessageBox.Show("Eski şifre yanlış veya kullanıcı adı hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Ödünç süresi ve ceza değerlerini kaydetme işlemi
            int? oduncGun = int.TryParse(txt_OduncSuresi.Text, out int tempOduncGun) ? tempOduncGun : (int?)null;
            decimal? ceza = decimal.TryParse(txt_CezaUcreti.Text, out decimal tempCeza) ? tempCeza : (decimal?)null;

            if (oduncGun.HasValue || ceza.HasValue)
            {
                if (AyarlariKaydet(oduncGun, ceza))
                {
                    MessageBox.Show("Ayarlar başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isUpdated = true;
                }
                else
                {
                    MessageBox.Show("Ayarları kaydederken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Eğer herhangi bir işlem yapıldıysa giriş bilgilerini temizle
            if (isUpdated)
            {
                txt_Sifre.Text = "";
                txt_YeniSifre.Text = "";
                txt_YeniSifreTekrar.Text = "";
            }
        }
    }
}
