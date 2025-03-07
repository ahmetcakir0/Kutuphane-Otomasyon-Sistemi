using Kütuphane_Otomasyon_Sistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class OduncForm : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        // Seçilen Kitap ve Üye ID'lerini saklayacak değişkenler
        private int SecilenKitapID;
        private int SecilenUyeID;

        public OduncForm()
        {
            InitializeComponent();
        }

        private void btn_UyeAra_Click(object sender, EventArgs e)
        {
            UyeAraPopupForm uyeAraPopupForm = new UyeAraPopupForm(connectionString);

            // Kullanıcı bir üye seçerse (DialogResult.OK)
            if (uyeAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                // Seçilen üye bilgilerini alıyoruz
                SecilenUyeID = uyeAraPopupForm.SecilenUyeID;
                txt_AlacakKisi.Text = uyeAraPopupForm.SecilenUyeAdiSoyadi; // Üye adı soyadını gösteriyoruz
            }
        }
        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            KitapAraPopupForm kitapAraPopupForm = new KitapAraPopupForm(connectionString);

            // Kullanıcı bir kitap seçerse (DialogResult.OK)
            if (kitapAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                // Seçilen kitap bilgilerini alıyoruz
                SecilenKitapID = kitapAraPopupForm.SecilenKitapID;
                txt_AlınacakKitap.Text = kitapAraPopupForm.SecilenKitapAdi; // Kitap adını gösteriyoruz
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AlacakKisi.Text) || string.IsNullOrEmpty(txt_AlınacakKitap.Text) ||
        dt_VerilenTarih.Value == null || dt_VerilmesiGerekenTarih.Value == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Alanlar eksikse kaydetme işlemini yapma
            }

            try
            {
                // Kitap ID'sini ve Üye ID'sini aldık, diğer parametreler ile ödünç verme işlemi yapılacak
                int kitapID = SecilenKitapID;
                int uyeID = SecilenUyeID;

                // Diğer veriler (tarihler vb.) alınacak
                DateTime verilenTarih = dt_VerilenTarih.Value;
                DateTime verilmesiGerekenTarih = dt_VerilmesiGerekenTarih.Value;

                // Ödünç verme işlemi
                string query = @"INSERT INTO Odunc (KitapID, UyeID, OduncVerilenTarih, GeriVerilmesiGerekenTarih)
                         VALUES (@KitapID, @UyeID, @OduncVerilenTarih, @GeriVerilmesiGerekenTarih)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);
                    cmd.Parameters.AddWithValue("@UyeID", uyeID);
                    cmd.Parameters.AddWithValue("@OduncVerilenTarih", verilenTarih);
                    cmd.Parameters.AddWithValue("@GeriVerilmesiGerekenTarih", verilmesiGerekenTarih);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // Yeni kayıt ekledikten sonra DataGrid'i yenile
                ListeyiYenile();

                MessageBox.Show("Ödünç işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void OduncForm_Load(object sender, EventArgs e)
        {
 
        }
        private void ListeyiYenile()
        {
            string query = @"SELECT o.UyeID, u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, o.KitapID, k.KitapAdi, o.OduncVerilenTarih, o.GeriVerilmesiGerekenTarih
                     FROM Odunc o
                     INNER JOIN Uyeler u ON o.UyeID = u.ID
                     INNER JOIN Kitaplar k ON o.KitapID = k.ID";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            // DataGridView'i yenile
            dgv_OduncListesi.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_AlacakKisi.Clear();
            txt_AlınacakKitap.Clear();

            // DateTimePicker'ları sıfırla
            dt_VerilenTarih.Value = DateTime.Now; // Şu anki tarihi seç
            dt_VerilmesiGerekenTarih.Value = DateTime.Now; // Şu anki tarihi seç

            // DataGridView seçimini kaldır
            if (dgv_OduncListesi.SelectedRows.Count > 0)
            {
                dgv_OduncListesi.ClearSelection();
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_OduncListesi.SelectedRows.Count > 0)
            {
                int secilenOduncID = Convert.ToInt32(dgv_OduncListesi.SelectedRows[0].Cells["UyeID"].Value); // veya ilgili ID'yi al

                // Silme işlemi
                string query = "DELETE FROM Odunc WHERE UyeID = @UyeID"; // Burada uygun ID'yi silmelisin
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UyeID", secilenOduncID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Silme işlemi tamamlandıktan sonra DataGrid'i yenile
                    ListeyiYenile();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadOduncIadeTablo()
        {
            string query = @"
SELECT 
    o.UyeID, 
    u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, 
    o.KitapID, 
    k.KitapAdi, 
    o.OduncVerilenTarih, 
    o.GeriVerilmesiGerekenTarih,
    o.IadeEdilenTarih,      -- İade edilen tarihi ekliyoruz
    o.IadeNotu AS IadeNotu,  -- İade ile ilgili notu ekliyoruz
    -- Ceza hesaplama: Eğer iade tarihi, geri verilmesi gereken tarihten geçiyorsa, 30 gün sonrasına kadar her gün için 10 TL ceza
    CASE 
        WHEN o.IadeEdilenTarih > o.GeriVerilmesiGerekenTarih 
        THEN DATEDIFF(DAY, o.GeriVerilmesiGerekenTarih, o.IadeEdilenTarih) * 10
        ELSE 0
    END AS CezaTutari
FROM Odunc o
INNER JOIN Uyeler u ON o.UyeID = u.ID    -- Üye bilgileri
INNER JOIN Kitaplar k ON o.KitapID = k.ID  -- Kitap bilgileri
";

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

                dgv_OduncIade.DataSource = dt;
                dgv_OduncIade.Columns["UyeID"].Visible = false;
                dgv_OduncIade.Columns["KitapID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            LoadOduncIadeTablo();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private DateTime GetOduncVerilenTarih(int oduncID)
        {
            DateTime verilenTarih = DateTime.Now;

            string query = @"SELECT OduncVerilenTarih 
                     FROM Odunc 
                     WHERE OduncID = @OduncID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@OduncID", oduncID);

                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    verilenTarih = Convert.ToDateTime(result);
                }
            }

            return verilenTarih;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (dgv_OduncListesi.SelectedRows.Count > 0)
            {
                // Seçilen satırdan ID'yi alıyoruz
                int secilenOduncID = Convert.ToInt32(dgv_OduncListesi.SelectedRows[0].Cells["OduncID"].Value); // veya uygun sütun ismi

                // İade işlemi için gerekli sorguları ve işlemleri burada yapıyoruz
                try
                {
                    DateTime iadeEdilenTarih = dt_GeriVerilenTarih.Value;  // İade edilen tarihi alıyoruz
                    DateTime oduncVerilenTarih = GetOduncVerilenTarih(secilenOduncID);  // Odunc verilen tarihi alıyoruz

                    // İlk olarak, bu ödünç kaydının zaten iade edilip edilmediğini kontrol edelim
                    string checkQuery = @"
                SELECT COUNT(*) 
                FROM OduncIade 
                WHERE OduncID = @OduncID";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, con))
                    {
                        cmdCheck.Parameters.AddWithValue("@OduncID", secilenOduncID);
                        con.Open();
                        int existingCount = (int)cmdCheck.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            MessageBox.Show("Bu ödünç kaydı zaten iade edilmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Ceza hesaplama
                    double cezaTutarı = 0;
                    if ((iadeEdilenTarih - oduncVerilenTarih).Days > 30)
                    {
                        int gecenGun = (iadeEdilenTarih - oduncVerilenTarih).Days;
                        cezaTutarı = gecenGun * 10;
                    }

                    // İade kaydını ekle
                    string insertQuery = @"
                INSERT INTO OduncIade (OduncID, UyeID, KitapID, IadeEdilenTarih, CezaTutar)
                VALUES (@OduncID, @UyeID, @KitapID, @IadeEdilenTarih, @CezaTutar)";

                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@OduncID", secilenOduncID);
                        cmdInsert.Parameters.AddWithValue("@UyeID", SecilenUyeID); // SecilenUyeID'nin önceden doğru şekilde atanması gerektiğini unutma
                        cmdInsert.Parameters.AddWithValue("@KitapID", SecilenKitapID); // SecilenKitapID de aynı şekilde atanmalı
                        cmdInsert.Parameters.AddWithValue("@IadeEdilenTarih", iadeEdilenTarih);
                        cmdInsert.Parameters.AddWithValue("@CezaTutar", cezaTutarı);

                        con.Open();
                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show("İade işlemi başarılı! Ceza: " + cezaTutarı.ToString("C2"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Veriyi güncelle
                    LoadOduncIadeTablo();  // Yeni iade sonrası tabloyu güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ödünç kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
