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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, KitapAdi FROM Kitaplar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv_KitapListesi.DataSource = dt;
            }
        }

        private void dgv_KitapListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SecilenKitapID = Convert.ToInt32(dgv_KitapListesi.Rows[e.RowIndex].Cells["ID"].Value);
                SecilenKitapAdi = dgv_KitapListesi.Rows[e.RowIndex].Cells["KitapAdi"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            if (dgv_KitapListesi.SelectedRows.Count > 0)
            {
                // Seçilen üyenin ID'sini al
                SecilenKitapID = Convert.ToInt32(dgv_KitapListesi.SelectedRows[0].Cells["ID"].Value);

                // Seçilen üyenin adı ve soyadını al
                SecilenKitapAdi = dgv_KitapListesi.SelectedRows[0].Cells["KitapAdi"].Value.ToString();

                // Eğer bir textbox varsa, oraya da yazalım
                if (this.Owner != null)
                {
                    TextBox txtSecilenKitap = this.Owner.Controls.Find("txtSecilenKitap", true).FirstOrDefault() as TextBox;
                    if (txtSecilenKitap != null)
                    {
                        txtSecilenKitap.Text = SecilenKitapAdi;
                    }
                }

                // Seçim tamamlandı, dialog'u OK olarak ayarla
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir üye seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
