using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kütuphane_Otomasyon_Sistemi
{
    public partial class UyeAraPopupForm : Form
    {
        private string connectionString;
        public int SecilenUyeID { get; private set; }
        public string SecilenUyeAdiSoyadi { get; private set; }
        private DataTable dtUyeler; // DataTable'ı sınıf seviyesinde tanımladık

        // Yapıcı metod
        public UyeAraPopupForm(string connString)
        {
            InitializeComponent();
            this.connectionString = connString;
        }

        // Form yüklendiğinde üyeleri yükleyen metod
        private void UyeAraPopupForm_Load(object sender, EventArgs e)
        {
            dgv_KisilerListesi.ClearSelection(); // DataGridView'deki seçimleri temizle
            LoadUyeler(); // Üyeleri yükle
        }

        // Üyeleri veritabanından alıp DataGridView'e yükleyen metod
        private void LoadUyeler()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT ID, Ad + ' ' + Soyad AS UyeAdiSoyadi FROM Uyeler";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    dtUyeler = new DataTable(); // DataTable'ı burada sınıf seviyesinde tanımladık
                    da.Fill(dtUyeler); // Verileri alıp dtUyeler'e yükledik
                    dgv_KisilerListesi.DataSource = dtUyeler; // DataGridView'e yükle
                }

                // ID kolonunu gizle
                if (dgv_KisilerListesi.Columns["ID"] != null)
                    dgv_KisilerListesi.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Arama butonuna tıklanınca arama işlemini gerçekleştiren metod
        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            string searchText = txt_KisiAra.Text.Trim().ToLower(); // Arama metnini al

            // Eğer DataGridView'in veri kaynağını al
            if (dtUyeler == null)
            {
                MessageBox.Show("Veri kaynağı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eğer arama metni boşsa, tüm verileri göster
            if (string.IsNullOrEmpty(searchText))
            {
                dtUyeler.DefaultView.RowFilter = ""; // Tüm satırları göster
            }
            else
            {
                // Arama metnine göre filtreleme yap
                dtUyeler.DefaultView.RowFilter = $"UyeAdiSoyadi LIKE '%{searchText}%'"; // Arama metnine göre filtre uygula
            }

            // Filtrelenmiş verileri DataGridView'e bağla
            dgv_KisilerListesi.DataSource = dtUyeler.DefaultView;
        }

        // DataGridView'de bir hücreye tıklanınca bu metot çalışır
        private void dgv_KisilerListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_KisilerListesi_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_KisilerListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow secilenSatir = dgv_KisilerListesi.SelectedRows[0]; // İlk seçili satırı al

                // Seçilen satırın verilerini al
                SecilenUyeID = Convert.ToInt32(secilenSatir.Cells["ID"].Value);
                SecilenUyeAdiSoyadi = secilenSatir.Cells["UyeAdiSoyadi"].Value.ToString();

                // Ana formuna bilgi gönder
                this.DialogResult = DialogResult.OK;
                this.Close(); // Pop-up formunu kapat
            }
        }

        private void dgv_KisilerListesi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_KisilerListesi.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
    }
}
