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

namespace Kütuphane_Otomasyon_Sistemi
{
    public partial class UyeAraPopupForm : Form
    {
        private string connectionString;
        public int SecilenUyeID { get; private set; }
        public string SecilenUyeAdiSoyadi { get; private set; }

        public UyeAraPopupForm(string connString)
        {
            InitializeComponent();
            this.connectionString = connString;
        }
        public void UyeListesiniYukle()
        {
            string query = "SELECT ID, Ad, Soyad FROM Uyeler"; // SQL sorgusu
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString)) // Veritabanı bağlantısı
                {
                    con.Open(); // Bağlantıyı aç

                    using (SqlCommand cmd = new SqlCommand(query, con)) // SQL komutu
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Veritabanından veri oku
                        {
                            dt.Load(reader); // Veriyi DataTable'a yükle
                        }
                    }
                }

                // Adi ve Soyadi'yi birleştirerek UyeAdiSoyadi kolonu ekleyelim
                dt.Columns.Add("UyeAdiSoyadi", typeof(string), "Ad + ' ' + Soyad");

                // DataGridView'e veri yükleme
                dgv_KisilerListesi.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Hata oluştuğunda kullanıcıya mesaj göster
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            if (dgv_KisilerListesi.SelectedRows.Count > 0)
            {
                // Seçilen üyenin ID'sini al
                SecilenUyeID = Convert.ToInt32(dgv_KisilerListesi.SelectedRows[0].Cells["ID"].Value);

                // Seçilen üyenin adı ve soyadını al
                SecilenUyeAdiSoyadi = dgv_KisilerListesi.SelectedRows[0].Cells["UyeAdiSoyadi"].Value.ToString();

                // Seçim tamamlandı, dialog'u OK olarak ayarla
                this.DialogResult = DialogResult.OK;
                this.Close(); // Popup'ı kapat
            }
            else
            {
                // Hiçbir üye seçilmediyse kullanıcıyı uyar
                MessageBox.Show("Lütfen bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UyeAraPopupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
