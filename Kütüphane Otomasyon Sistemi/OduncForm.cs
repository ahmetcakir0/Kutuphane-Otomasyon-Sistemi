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
        o.ID,
        o.UyeID, 
        u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, 
        o.KitapID, 
        k.KitapAdi, 
        o.OduncVerilenTarih, 
        o.GeriVerilmesiGerekenTarih,
        o.IadeEdilenTarih,  
        o.IadeNotu,
        o.CezaTutari  -- Bu alan zaten veritabanında var, biz burada ceza hesaplamayacağız
    FROM Odunc o
    INNER JOIN Uyeler u ON o.UyeID = u.ID
    INNER JOIN Kitaplar k ON o.KitapID = k.ID";

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

                // DataGridView'e veri yükle
                dgv_OduncIade.DataSource = dt;

                // CezaTutari'ni sadece görünümde formatlayalım (Örneğin sağa hizalamak)
                dgv_OduncIade.Columns["CezaTutari"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Diğer sütunların görünürlüğünü ayarla
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
        private void FormatCezaTutariColumn(DataGridView dgv)
        {
            // CezaTutari sütununu kontrol et
            if (dgv.Columns.Contains("CezaTutari"))
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    // Eğer CezaTutari null ya da boş değilse
                    if (row.Cells["CezaTutari"].Value != DBNull.Value)
                    {
                        int cezaTutari = Convert.ToInt32(row.Cells["CezaTutari"].Value);

                        // CezaTutari'ni formatla (örneğin: TL olarak göstermek)
                        row.Cells["CezaTutari"].Value = cezaTutari.ToString("C2");  // "C2" formatı ile TL cinsinden iki ondalıklı gösterim
                    }
                }

                // CezaTutari sütununu sağa hizala
                dgv.Columns["CezaTutari"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private DateTime GetOduncVerilenTarih(int oduncID)
        {
            DateTime verilenTarih = DateTime.Now;

            string query = @"SELECT OduncVerilenTarih 
                     FROM Odunc 
                     WHERE ID = @ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ID", oduncID);

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
            try
            {
                if (dgv_OduncIade.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen iade etmek için bir ödünç kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var secilenSatir = dgv_OduncIade.SelectedRows[0];

                if (secilenSatir.Cells["ID"].Value == DBNull.Value ||
                    secilenSatir.Cells["UyeID"].Value == DBNull.Value ||
                    secilenSatir.Cells["KitapID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Geçersiz kayıt! Lütfen başka bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int secilenOduncID = Convert.ToInt32(secilenSatir.Cells["ID"].Value);
                string iadeNotu = txt_IadeNotu.Text.Trim(); // **İade Notunu Al**
                DateTime iadeEdilenTarih = dt_GeriVerilenTarih.Value;

                // **Ödünç Verilen Tarihi Doğru Çek**
                DateTime oduncVerilenTarih;
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT OduncVerilenTarih FROM Odunc WHERE ID = @ID", con))
                {
                    cmd.Parameters.AddWithValue("@ID", secilenOduncID);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                    {
                        MessageBox.Show("Ödünç verilen tarih bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    oduncVerilenTarih = Convert.ToDateTime(result);
                }

                // **Ceza Hesaplama (Günlük 10₺, 30 Günü Geçerse)**
                double cezaTutarı = 0;
                int gecenGun = (iadeEdilenTarih - oduncVerilenTarih).Days;

                if (gecenGun > 30)
                {
                    int gecikmeGun = gecenGun - 30;
                    cezaTutarı = gecikmeGun * 10;
                }

                // **Veritabanı Güncelleme Sorgusu**
                string updateQuery = @"
        UPDATE Odunc
        SET IadeEdilenTarih = @IadeEdilenTarih, CezaTutari = @CezaTutari, IadeNotu = @IadeNotu
        WHERE ID = @ID";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@IadeEdilenTarih", iadeEdilenTarih);
                    cmd.Parameters.AddWithValue("@CezaTutari", cezaTutarı);
                    cmd.Parameters.AddWithValue("@IadeNotu", string.IsNullOrEmpty(iadeNotu) ? (object)DBNull.Value : iadeNotu);
                    cmd.Parameters.AddWithValue("@ID", secilenOduncID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                // **Doğru Bilgiyle Kullanıcıya Mesaj Göster**
                MessageBox.Show($"İade işlemi başarılı!\nGeciken Gün: {gecenGun - 30}\nCeza Tutarı: {cezaTutarı:C2}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // **TABLOYU YENİLE**
                LoadOduncIadeTablo();

                // **SEÇİLİ SATIRI TEMİZLE**
                dgv_OduncIade.ClearSelection();
                txt_IadeNotu.Clear();
                dt_GeriVerilenTarih.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_OduncIade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_OduncIade.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki bilgileri al
                var secilenSatir = dgv_OduncIade.SelectedRows[0];
                int secilenOduncID = Convert.ToInt32(secilenSatir.Cells["ID"].Value);  // "OduncID" hücresini kullanıyoruz

                // Burada işlemlerinizi gerçekleştirebilirsiniz.
            }
            else
            {
                // Eğer hiç satır seçilmediyse, işlem yapma
                MessageBox.Show("Lütfen bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
