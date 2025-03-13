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

        private void UyeAraPopupForm_Load(object sender, EventArgs e)
        {
            LoadUyeler();
        }

        private void LoadUyeler()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT ID, Ad + ' ' + Soyad AS UyeAdiSoyadi FROM Uyeler";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_KisilerListesi.DataSource = dt;
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

        private void btn_KisiAra_Click(object sender, EventArgs e)
        {
            UyeSec();
        }

        private void dgv_KisilerListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SecilenUyeID = Convert.ToInt32(dgv_KisilerListesi.Rows[e.RowIndex].Cells["ID"].Value);
                SecilenUyeAdiSoyadi = dgv_KisilerListesi.Rows[e.RowIndex].Cells["UyeAdiSoyadi"].Value.ToString();
                                      
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgv_KisilerListesi_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UyeSec();
            }
        }
        private void UyeSec()
        {
            if (dgv_KisilerListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow secilenSatir = dgv_KisilerListesi.SelectedRows[0]; // İlk seçili satırı al

                SecilenUyeID = Convert.ToInt32(secilenSatir.Cells["ID"].Value);
                SecilenUyeAdiSoyadi = secilenSatir.Cells["UyeAdiSoyadi"].Value?.ToString(); // UyeAdiSoyadi sütununu al

                if (string.IsNullOrEmpty(SecilenUyeAdiSoyadi))
                {
                    MessageBox.Show("Seçilen üye bilgileri eksik.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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