using Kütuphane_Otomasyon_Sistemi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class RezervasyonForm : Form
    {
        public int SecilenUyeID { get; set; }
        public int SecilenKitapID { get; set; }

        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void btn_UyeAra_Click(object sender, EventArgs e)
        {
            UyeAraPopupForm uyeAraPopupForm = new UyeAraPopupForm(connectionString);
            if (uyeAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                SecilenUyeID = uyeAraPopupForm.SecilenUyeID;
                txt_RezervasyonUye.Text = uyeAraPopupForm.SecilenUyeAdiSoyadi;
            }
        }

        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            KitapAraPopupForm kitapAraPopupForm = new KitapAraPopupForm(connectionString);
            if (kitapAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                SecilenKitapID = kitapAraPopupForm.SecilenKitapID;
                txt_RezervasyonKitap.Text = kitapAraPopupForm.SecilenKitapAdi;
            }
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            string query = "SELECT " +
                           "R.ID AS RezervasyonID, " + // Rezervasyon ID'si eklendi
                           "U.ID AS UyeID, " +
                           "U.Ad + ' ' + U.Soyad AS UyeAdiSoyadi, " +
                           "K.ID AS KitapID, " +
                           "K.KitapAdi, " +
                           "R.RezervasyonTarihi, " +
                           "R.Aciklama " +
                           "FROM Uyeler U " +
                           "JOIN Rezervasyon R ON U.ID = R.UyeID " +
                           "JOIN Kitaplar K ON R.KitapID = K.ID " +
                           "ORDER BY R.ID DESC;"; // Rezervasyon ID'sine göre ters sıralama

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                try
                {
                    dataAdapter.Fill(dataTable);
                    dgv_Rezervasyon.DataSource = dataTable; // Bind the DataGridView to the data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            if (SecilenUyeID == 0 || SecilenKitapID == 0)
            {
                MessageBox.Show("Lütfen bir üye ve kitap seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aynı üye aynı kitaba rezervasyon yapmış mı kontrol et
            if (IsUyeKitapIcinRezervasyonVarmi(SecilenUyeID, SecilenKitapID))
            {
                MessageBox.Show("Bu üye zaten bu kitaba rezervasyon yapmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Aynı kitaba rezervasyon yapılmasını engeller
            }

            // Rezervasyon tarihini ve açıklamayı al
            DateTime rezervasyonTarihi = DateTime.Now; // Şu anki tarih ve saat
            string aciklama = txt_Aciklama.Text; // Açıklama metin kutusundan alınır

            string query = "INSERT INTO Rezervasyon (UyeID, KitapID, RezervasyonTarihi, Aciklama) " +
                           "VALUES (@UyeID, @KitapID, @RezervasyonTarihi, @Aciklama)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", SecilenUyeID);
                    command.Parameters.AddWithValue("@KitapID", SecilenKitapID);
                    command.Parameters.AddWithValue("@RezervasyonTarihi", rezervasyonTarihi);
                    command.Parameters.AddWithValue("@Aciklama", aciklama);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Rezervasyon başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReservations(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Rezervasyon eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool IsUyeKitapIcinRezervasyonVarmi(int uyeID, int kitapID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM Rezervasyon 
                WHERE UyeID = @UyeID AND KitapID = @KitapID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UyeID", uyeID);
                        cmd.Parameters.AddWithValue("@KitapID", kitapID);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // Eğer rezervasyon bulunursa, true döner
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon kontrol edilirken hata oluştu: " + ex.Message);
                return false;
            }
        }

    }
}