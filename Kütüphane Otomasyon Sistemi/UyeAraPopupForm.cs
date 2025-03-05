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
        public string SecilenUye { get; private set; }

        public UyeAraPopupForm()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
            string query = "SELECT ID, Ad + ' ' + Soyad AS AdSoyad FROM Uyeler";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_KisilerListesi.DataSource = dt; // Verileri DataGridView'e yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            if (dgv_KisilerListesi.SelectedRows.Count > 0)
            {
                // Seçili satırın AdSoyad kolonunu al
                SecilenUye = dgv_KisilerListesi.SelectedRows[0].Cells["AdSoyad"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçin.");
            }
        }
    }
}
