using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class YazarAraPopupForm : Form
    {
        public string SecilenYazar { get; private set; }
        public int SecilenYazarId { get; private set; }

        public YazarAraPopupForm()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
            string query = "SELECT ID, AdiSoyadi FROM Yazarlar";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_YazarListesi.DataSource = dt; // Verileri DataGridView'e yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void dgv_YazarListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_YazarAra_Click(object sender, EventArgs e)
        {
            string searchText = txt_YazarAra.Text.Trim().ToLower();

            // DataGridView'in veri kaynağını al (DataTable olarak)
            DataTable dt = dgv_YazarListesi.DataSource as DataTable;

            if (dt == null)
            {
                MessageBox.Show("Veri kaynağı bulunamadı.");
                return;
            }

            // Eğer arama metni boşsa, tüm verileri göster
            if (string.IsNullOrEmpty(searchText))
            {
                dt.DefaultView.RowFilter = "";
            }
            else
            {
                // Arama metnine göre filtreleme yap
                dt.DefaultView.RowFilter = $"AdiSoyadi LIKE '%{searchText}%'";
            }

            // Filtrelenmiş verileri DataGridView'e bağla
            dgv_YazarListesi.DataSource = dt.DefaultView;
        }

        private void YazarAraPopupForm_Load(object sender, EventArgs e)
        {
            dgv_YazarListesi.ClearSelection();
        }

        private void YazarAraPopupForm_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_YazarListesi.SelectedRows.Count > 0)
            {
                // Seçilen satırı alıyoruz
                DataGridViewRow row = dgv_YazarListesi.SelectedRows[0];
                SecilenYazar = row.Cells["AdiSoyadi"].Value.ToString();  // Yazar adı
                SecilenYazarId = Convert.ToInt32(row.Cells["ID"].Value); // Yazar ID

                // Ana forma bu bilgileri aktarmak için DialogResult OK yapıyoruz
                this.DialogResult = DialogResult.OK;
                this.Close();  // Pop-up formunu kapat
            }
            else
            {
                MessageBox.Show("Lütfen bir yazar seçin.");
            }
        }
    }
}