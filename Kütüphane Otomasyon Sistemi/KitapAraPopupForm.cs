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
        private string connectionString;
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
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
