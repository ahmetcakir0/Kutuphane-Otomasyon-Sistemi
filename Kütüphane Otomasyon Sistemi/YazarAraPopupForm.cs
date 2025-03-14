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
            if (dgv_YazarListesi.SelectedRows.Count > 0)
            {
                SecilenYazar = dgv_YazarListesi.SelectedRows[0].Cells["AdiSoyadi"].Value.ToString();
                SecilenYazarId = Convert.ToInt32(dgv_YazarListesi.SelectedRows[0].Cells["ID"].Value);

                // Ana forma bu bilgileri aktarmak için DialogResult OK yapıyoruz.
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Lütfen bir yazar seçin.");
            }
        }
    }
}
