using Kütuphane_Otomasyon_Sistemi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class OduncForm : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
        private int SecilenKitapID;
        private int SecilenUyeID;

        public OduncForm()
        {
            InitializeComponent();
        }

        // Üye Arama Butonu
        private void btn_UyeAra_Click(object sender, EventArgs e)
        {
            using (UyeAraPopupForm uyeAraPopupForm = new UyeAraPopupForm(connectionString))
            {
                if (uyeAraPopupForm.ShowDialog() == DialogResult.OK)
                {
                    SecilenUyeID = uyeAraPopupForm.SecilenUyeID;
                    txt_AlacakKisi.Text = uyeAraPopupForm.SecilenUyeAdiSoyadi;
                }
            }
        }

        // Kitap Arama Butonu
        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            using (KitapAraPopupForm kitapAraPopupForm = new KitapAraPopupForm(connectionString))
            {
                if (kitapAraPopupForm.ShowDialog() == DialogResult.OK)
                {
                    SecilenKitapID = kitapAraPopupForm.SecilenKitapID;
                    txt_AlınacakKitap.Text = kitapAraPopupForm.SecilenKitapAdi;
                }
            }
        }

        // Ödünç Verme ve Kaydetme Butonu
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AlacakKisi.Text) || string.IsNullOrEmpty(txt_AlınacakKitap.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ayalar tablosundaki ödünç süresini alıyoruz
                int loanDurationDays = GetLoanDurationFromAyalar();

                DateTime verilenTarih = dt_VerilenTarih.Value;
                DateTime verilmesiGerekenTarih = verilenTarih.AddDays(loanDurationDays);

                // Odunc tablosuna yeni bir ödünç kaydı ekliyoruz
                string query = @"INSERT INTO Odunc (KitapID, UyeID, OduncVerilenTarih, GeriVerilmesiGerekenTarih)
                                 VALUES (@KitapID, @UyeID, @OduncVerilenTarih, @GeriVerilmesiGerekenTarih)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@KitapID", SecilenKitapID);
                    cmd.Parameters.AddWithValue("@UyeID", SecilenUyeID);
                    cmd.Parameters.AddWithValue("@OduncVerilenTarih", verilenTarih);
                    cmd.Parameters.AddWithValue("@GeriVerilmesiGerekenTarih", verilmesiGerekenTarih);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                ListeyiYenile();
                MessageBox.Show("Ödünç işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ayalar tablosundan ödünç süresini almak için metod
        private int GetLoanDurationFromAyalar()
        {
            string query = "SELECT OduncSuresi FROM Ayalar WHERE ID = 1"; // Ayalar tablosundaki OduncSuresi değeri
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 30; // Varsayılan olarak 30 gün
            }
        }

        // Listeyi Yenileme
        private void ListeyiYenile()
        {
            string query = @"SELECT o.UyeID, u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, o.KitapID, k.KitapAdi, o.OduncVerilenTarih, o.GeriVerilmesiGerekenTarih
                             FROM Odunc o
                             INNER JOIN Uyeler u ON o.UyeID = u.ID
                             INNER JOIN Kitaplar k ON o.KitapID = k.ID";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            dgv_OduncListesi.DataSource = dt;
        }

        // Temizleme Butonu
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_AlacakKisi.Clear();
            txt_AlınacakKitap.Clear();
            dt_VerilenTarih.Value = DateTime.Now;
            dgv_OduncListesi.ClearSelection();
        }

        // Silme Butonu
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_OduncListesi.SelectedRows.Count > 0)
            {
                int secilenOduncID = Convert.ToInt32(dgv_OduncListesi.SelectedRows[0].Cells["UyeID"].Value);

                string query = "DELETE FROM Odunc WHERE UyeID = @UyeID";
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UyeID", secilenOduncID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

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
    }
}
