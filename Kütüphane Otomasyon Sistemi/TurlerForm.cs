using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class TurlerForm : Form
    {
        private readonly TurBL turBL;
        private int seciliTurId = 0; // Seçili türün ID'sini tutan değişken

        public TurlerForm()
        {
            InitializeComponent();
            turBL = new TurBL();
        }

        private void TurlerForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void FormTemizle()
        {
            txt_TurEkle.Clear();
            txt_Aciklama.Clear();
            seciliTurId = 0; // Seçili ID sıfırlanıyor
            dgv_TurListesi.ClearSelection();
            txt_TurEkle.Focus();
        }
        private void ListeyiYenile()
        {
            try
            {
                var turlerTablosu = turBL.TumTurleriGetir();
                dgv_TurListesi.DataSource = turlerTablosu;
                dgv_TurListesi.ClearSelection(); // Listeyi yenileyince seçimi kaldır
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                string turAdi = txt_TurEkle.Text.Trim();
                string aciklama = txt_Aciklama.Text.Trim();

                // Eğer form tamamen boşsa işlem yapma
                if (string.IsNullOrWhiteSpace(turAdi) && string.IsNullOrWhiteSpace(aciklama))
                {
                    MessageBox.Show("Lütfen geçerli bir tür bilgisi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sonuc;

                if (seciliTurId > 0) // **Eğer ID varsa güncelleme işlemi**
                {
                    sonuc = turBL.TurGuncelle(seciliTurId, turAdi, aciklama);
                }
                else // **Yeni ekleme işlemi**
                {
                    sonuc = turBL.TurEkle(turAdi, aciklama);
                }

                if (sonuc.Contains("başarıyla")) // Başarılı işlem
                {
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                    FormTemizle();
                }
                else // Uyarı mesajı
                {
                    MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }



        private void txt_TurEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) // 8 = Backspace
            {
                e.Handled = true;  // Eğer karakter harf değilse, girmeyi engelle
            }
        }

        private void dgv_TurListesi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_TurListesi.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void dgv_TurListesi_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_TurListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_TurListesi.SelectedRows[0];

                // Null kontrolü
                if (row.Cells["TurID"].Value != null)
                {
                    seciliTurId = Convert.ToInt32(row.Cells["TurID"].Value);
                    txt_TurEkle.Text = row.Cells["TurAdi"].Value?.ToString() ?? "";
                    txt_Aciklama.Text = row.Cells["Aciklama"].Value?.ToString() ?? "";

                    // Eğer başka alanlar varsa:
                    // txt_DigerAlan.Text = row.Cells["DigerAlan"].Value?.ToString() ?? "";
                }
            }
        }
    }
}
