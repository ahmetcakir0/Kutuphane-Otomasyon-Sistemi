using System;
using System.Data;
using System.Windows.Forms;
using BusinessLayer;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class TurlerForm : Form
    {
        private readonly TurBL turBL;

        public TurlerForm()
        {
            InitializeComponent();
            turBL = new TurBL();  // Connection string'ini burada kullanmıyoruz, TurBL sınıfı kendi bağlantısını yönetiyor.
        }

        private void TurlerForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde türler listesini yenileyelim
            ListeyiYenile();
        }

        private void FormTemizle()
        {
            // Formdaki inputları temizleyelim
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

                // Tür ekleme işlemi
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
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_TurListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Seçilen satırdaki ID'yi alalım
                int id = Convert.ToInt32(dgv_TurListesi.SelectedRows[0].Cells["ID"].Value);
                string turAdi = txt_TurEkle.Text.Trim();
                string aciklama = txt_Aciklama.Text.Trim();

                // Tür güncelleme işlemi
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
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListeyiYenile()
        {
            try
            {
                // `TurBL` sınıfındaki `TumTurleriGetir` metodunu çağırarak veriyi alıyoruz.
                var turlerTablosu = turBL.TumTurleriGetir();

                // Veriyi DataGridView'e atıyoruz
                dgv_TurListesi.DataSource = turlerTablosu;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
