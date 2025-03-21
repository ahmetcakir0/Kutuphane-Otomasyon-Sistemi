using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
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
    public partial class YazarKayitForm : Form
    {
        private readonly YazarBL yazarBL;

        public YazarKayitForm()
        {
            InitializeComponent();
            yazarBL = new YazarBL();
        }


        private void YazarKayitForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();

            dgv_YazarListesi.ClearSelection();
            dgv_YazarListesi.CurrentCell = null;
        }

        private void FormTemizle()
        {
            txt_YazarAdSoyad.Clear();
            txt_Biyografi.Clear();
            txt_Iletisim.Clear();
            txt_YazarAdSoyad.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Yazar nesnesi oluşturuluyor
                Yazar yeniYazar = new Yazar
                {
                    AdiSoyadi = txt_YazarAdSoyad.Text.Trim(),
                    Iletisim = txt_Iletisim.Text.Trim(),
                    DogumTarihi = dtp_DogumTarihi.Value,
                    Biyografi = txt_Biyografi.Text.Trim()
                };

                // Eğer form tamamen boşsa işlem yapma
                if (string.IsNullOrWhiteSpace(yeniYazar.AdiSoyadi) ||
                    string.IsNullOrWhiteSpace(yeniYazar.Iletisim) ||
                    string.IsNullOrWhiteSpace(yeniYazar.Biyografi))
                {
                    MessageBox.Show("Lütfen geçerli bir yazar bilgisi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sonuc = string.Empty;

                // Yeni yazar ekleme mi yoksa güncelleme mi yapılacak?
                if (seciliYazarId == 0) // Yeni kayıt
                {
                    // İletişim kontrolü yapılıyor
                    if (yazarBL.IletisimVarMi(yeniYazar.Iletisim))  // Eğer iletişim varsa
                    {
                        MessageBox.Show("Bu iletişim bilgisi zaten kullanılmakta!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Eğer iletişim mevcutsa, işlem durduruluyor
                    }

                    sonuc = yazarBL.YazarEkle(yeniYazar); // Yeni yazar ekleme işlemi
                }
                else // Güncelleme
                {
                    yeniYazar.ID = seciliYazarId; // Güncellenecek olan yazarın ID'sini belirtiyoruz.
                    sonuc = yazarBL.YazarGuncelle(seciliYazarId, yeniYazar); // ID ile birlikte Yazar nesnesi gönderiyoruz
                }

                // İşlem sonucu
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
                // Hata mesajı
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ListeyiYenile()
        {
            try
            {
                // `TurBL` sınıfındaki `TumTurleriGetir` metodunu çağırarak veriyi alıyoruz.
                var yazarlarTablosu = yazarBL.TumYazarlariGetir();

                // Veriyi DataGridView'e atıyoruz
                dgv_YazarListesi.DataSource = yazarlarTablosu;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int seciliYazarId = 0; // Seçilen yazarın ID’sini tutacak değişken

        private void dgv_YazarlarListesi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_YazarListesi.SelectedRows.Count > 0)
            {
                // Seçili satırdan ID'yi al
                seciliYazarId = Convert.ToInt32(dgv_YazarListesi.SelectedRows[0].Cells["YazarId"].Value);

                // Diğer bilgileri ilgili alanlara doldur
                txt_YazarAdSoyad.Text = dgv_YazarListesi.SelectedRows[0].Cells["YazarAdSoyad"].Value.ToString();
                txt_Iletisim.Text = dgv_YazarListesi.SelectedRows[0].Cells["Iletisim"].Value.ToString();
                dtp_DogumTarihi.Value = Convert.ToDateTime(dgv_YazarListesi.SelectedRows[0].Cells["DogumTarihi"].Value);
                txt_Biyografi.Text = dgv_YazarListesi.SelectedRows[0].Cells["Biyografi"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_YazarAdSoyad.Clear();
            txt_Iletisim.Clear();
            txt_Biyografi.Clear();
            dtp_DogumTarihi.Value = DateTime.Now;

            seciliYazarId = 0; // Seçili yazar sıfırlanır
            dgv_YazarListesi.ClearSelection(); // Seçimi kaldır
        }

        private void txt_YazarAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8) // (char)8 = Backspace
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void dgv_YazarListesi_Click(object sender, EventArgs e)
        {
            if (dgv_YazarListesi.SelectedRows.Count > 0)
            {
                seciliYazarId = Convert.ToInt32(dgv_YazarListesi.SelectedRows[0].Cells["Id"].Value);
                txt_YazarAdSoyad.Text = dgv_YazarListesi.SelectedRows[0].Cells["AdiSoyadi"].Value.ToString();
                txt_Iletisim.Text = dgv_YazarListesi.SelectedRows[0].Cells["Iletisim"].Value.ToString();
                dtp_DogumTarihi.Value = Convert.ToDateTime(dgv_YazarListesi.SelectedRows[0].Cells["DogumTarihi"].Value);
                txt_Biyografi.Text = dgv_YazarListesi.SelectedRows[0].Cells["Biyografi"].Value.ToString();
            }
        }

        private void dgv_YazarListesi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_YazarListesi.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }
}
