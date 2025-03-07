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
            string query = "SELECT ID, Ad + ' ' + Soyad AS UyeAdiSoyadi FROM Uyeler"; // Ad ve Soyad'ı SQL içinde birleştirdik
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

                // DataGridView'e sadece UyeAdiSoyadi kolonunu göster
                dgv_KisilerListesi.DataSource = dt;
                dgv_KisilerListesi.Columns["ID"].Visible = false; // ID kolonunu gizle
            }
            catch (Exception ex)
            {
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

                // Eğer bir textbox varsa, oraya da yazalım
                if (this.Owner != null)
                {
                    TextBox txtSecilenUye = this.Owner.Controls.Find("txtSecilenUye", true).FirstOrDefault() as TextBox;
                    if (txtSecilenUye != null)
                    {
                        txtSecilenUye.Text = SecilenUyeAdiSoyadi;
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

        private void dgv_KisilerListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KisilerListesi.Rows[e.RowIndex];

                // Seçilen üyenin ID ve Adı Soyadı bilgilerini al
                SecilenUyeID = Convert.ToInt32(row.Cells["ID"].Value);
                SecilenUyeAdiSoyadi = row.Cells["UyeAdiSoyadi"].Value.ToString();

                // **Textbox'a Değer Gönder**
                if (this.Owner != null)
                {
                    TextBox txtSecilenUye = this.Owner.Controls.Find("txt_AlacakKisi", true).FirstOrDefault() as TextBox;
                    if (txtSecilenUye != null)
                    {
                        txtSecilenUye.Text = SecilenUyeAdiSoyadi;
                    }
                }

                // Dialog Sonlandır
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}