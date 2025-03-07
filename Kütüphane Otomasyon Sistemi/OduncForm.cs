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
    o.IadeEdilenTarih,      -- İade edilen tarihi ekliyoruz
    o.IadeNotu AS IadeNotu,  -- İade ile ilgili notu ekliyoruz      -- Odunc tablosundaki ID sütununu OduncID olarak alıyoruz
    u.ID AS UyeID,           -- Uyeler tablosundaki ID'yi alıyoruz
    k.ID AS KitapID,         -- Kitaplar tablosundaki ID'yi alıyoruz
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
                // Seçili satır var mı kontrol et
                if (dgv_OduncIade.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen iade etmek için bir ödünç kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Seçim yapılmadıysa işlemi durdur
                }

                // Seçilen satırdaki OduncID değerini alıyoruz
                var secilenSatir = dgv_OduncListesi.SelectedRows[0];  // Seçilen satırı alıyoruz
                int secilenOduncID = Convert.ToInt32(secilenSatir.Cells["ID"].Value);  // "OduncID" hücresini kullanıyoruz

                DateTime iadeEdilenTarih = dt_GeriVerilenTarih.Value;  // İade edilen tarihi alıyoruz
                DateTime oduncVerilenTarih = GetOduncVerilenTarih(secilenOduncID);  // Seçili ödünç kaydına ait ödünç verilen tarihi alıyoruz

                // Ceza hesaplama
                double cezaTutarı = 0;
                if ((iadeEdilenTarih - oduncVerilenTarih).Days > 30)  // 30 günden fazla gecikme varsa ceza hesaplanacak
                {
                    int gecenGun = (iadeEdilenTarih - oduncVerilenTarih).Days;
                    cezaTutarı = gecenGun * 10; // Her geç kalan gün için 10 TL ceza
                }

                // Ödünç kaydının iade tarihini ve ceza tutarını güncelleme
                string updateQuery = @"
            UPDATE Odunc
            SET IadeEdilenTarih = @IadeEdilenTarih, CezaTutar = @CezaTutar
            WHERE ID = @ID";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@IadeEdilenTarih", iadeEdilenTarih);
                    cmd.Parameters.AddWithValue("@CezaTutar", cezaTutarı);
                    cmd.Parameters.AddWithValue("@ID", secilenOduncID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("İade işlemi başarılı! Ceza: " + cezaTutarı.ToString("C2"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Veriyi güncelle
                ListeyiYenile();  // Tabloyu yenileyin
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
