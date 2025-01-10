
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;
using System.Data.SqlClient;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class TurlerForm : Form
    {
        private readonly TurBL turBL;
        private readonly string connectionString;

        public TurlerForm()
        {
            InitializeComponent();
            string connectionString = "Server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=Turler; Integrated Security=SSPI";
            turBL = new TurBL(connectionString);
        }
        private void TurlerForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
        private void FetchData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Turler";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string data = reader["ColumnName"].ToString();
                        MessageBox.Show(data);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FormTemizle()
        {
            txt_TurEkle.Clear();
            txt_Aciklama.Clear();
            txt_TurEkle.Focus();
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                string turAdi = txt_TurEkle.Text.Trim();
                string aciklama = txt_Aciklama.Text.Trim();

                string sonuc = turBL.TurEkle(turAdi, aciklama);

                if (sonuc == "Tür başarıyla eklendi.")
                {
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                    FormTemizle();
                }
                else
                {
                    MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (TurListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek türü seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(TurListesi.SelectedRows[0].Cells["ID"].Value);
                string turAdi = txt_TurEkle.Text.Trim();
                string aciklama = txt_Aciklama.Text.Trim();

                string sonuc = turBL.TurGuncelle(id, turAdi, aciklama);

                if (sonuc == "Tür başarıyla güncellendi.")
                {
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                    FormTemizle();
                }
                else
                {
                    MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListeyiYenile()
        {
            try
            {
                var turlerTablosu = turBL.TumTurleriGetir();
                TurListesi.DataSource = turlerTablosu;

                if (TurListesi.Columns.Count > 0)
                {
                    TurListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (TurListesi.Columns.Contains("ID"))
                        TurListesi.Columns["ID"].HeaderText = "ID";
                    if (TurListesi.Columns.Contains("TurAdi"))
                        TurListesi.Columns["TurAdi"].HeaderText = "Tür Adı";
                    if (TurListesi.Columns.Contains("Aciklama"))
                        TurListesi.Columns["Aciklama"].HeaderText = "Açıklama";
                }

                TurListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
