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
                           "U.ID AS UyeID, " +
                           "U.Ad + ' ' + U.Soyad AS UyeAdiSoyadi, " +
                           "K.ID AS KitapID, " +
                           "K.KitapAdi " +
                           "FROM Uyeler U " +
                           "JOIN Rezervasyon R ON U.ID = R.UyeID " +
                           "JOIN Kitaplar K ON R.KitapID = K.ID;";

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

            string query = "INSERT INTO Rezervasyon (UyeID, KitapID) " +
                           "VALUES (@UyeID, @KitapID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", SecilenUyeID);
                    command.Parameters.AddWithValue("@KitapID", SecilenKitapID);

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
    }
}