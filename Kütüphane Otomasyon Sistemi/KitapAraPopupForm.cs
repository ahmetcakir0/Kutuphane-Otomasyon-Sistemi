using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class KitapAraPopupForm : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
        public int SecilenKitapID { get; private set; }
        public string SecilenKitapAdi { get; private set; }

        public KitapAraPopupForm(string connString)
        {
            InitializeComponent();
            this.connectionString = connString;
        }

        private void KitapAraPopupForm_Load(object sender, EventArgs e)
        {
            dgv_KitapListesi.ClearSelection(); // DataGridView'deki seçimleri temizle
            LoadKitaplar(); // Kitapları yükle
        }

        // Kitapları veritabanından alıp DataGridView'e yükleyen metod
        private void LoadKitaplar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ID, KitapAdi FROM Kitaplar";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_KitapListesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DataGridView'de bir hücreye tıklanınca bu metot çalışır
        private void dgv_KitapListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // Arama butonuna tıklanınca arama işlemini gerçekleştiren metod
        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            string searchText = txt_KitapAra.Text.Trim().ToLower(); // Arama metnini al

            // Eğer DataGridView'in veri kaynağını al
            DataTable dtKitaplar = dgv_KitapListesi.DataSource as DataTable;

            if (dtKitaplar == null)
            {
                MessageBox.Show("Veri kaynağı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Eğer arama metni boşsa, tüm verileri göster
            if (string.IsNullOrEmpty(searchText))
            {
                dtKitaplar.DefaultView.RowFilter = ""; // Tüm satırları göster
            }
            else
            {
                // Arama metnine göre filtreleme yap
                dtKitaplar.DefaultView.RowFilter = $"KitapAdi LIKE '%{searchText}%'"; // Arama metnine göre filtre uygula
            }

            // Filtrelenmiş verileri DataGridView'e bağla
            dgv_KitapListesi.DataSource = dtKitaplar.DefaultView;
        }

        private void dgv_KitapListesi_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            // Satır seçilmediği takdirde (boş satır veya geçerli satır yoksa) işlem yapma
            if (dgv.SelectedRows.Count > 0)
            {
                // Seçilen satırın ilk (tek) satırını alıyoruz
                DataGridViewRow row = dgv.SelectedRows[0];

                // Seçilen kitap ID'sini ve adını alıyoruz
                SecilenKitapID = Convert.ToInt32(row.Cells["ID"].Value);
                SecilenKitapAdi = row.Cells["KitapAdi"].Value.ToString();

                // Ana forma bu bilgileri aktarmak için DialogResult OK yapıyoruz.
                this.DialogResult = DialogResult.OK;
                this.Close(); // Pop-up formunu kapat
            }
        }
    }
}
