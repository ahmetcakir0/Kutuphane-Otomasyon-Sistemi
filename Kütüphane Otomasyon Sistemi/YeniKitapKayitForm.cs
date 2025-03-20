using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class YeniKitapKayitForm : Form
    {
        private KitapBL kitapBL;
        private YayineviBL yayineviBL;
        private KatRafBL katRafBL;
        private TurBL turBL;
        private int seciliKitapId = 0;
        private int seciliYazarId;

        public YeniKitapKayitForm()
        {
            InitializeComponent();
            kitapBL = new KitapBL();
            yayineviBL = new YayineviBL();
            katRafBL = new KatRafBL();
            turBL = new TurBL();
        }

        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            YazarAraPopupForm yazarAraPopupForm = new YazarAraPopupForm();

            if (yazarAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                txt_Yazar.Text = yazarAraPopupForm.SecilenYazar;
                seciliYazarId = yazarAraPopupForm.SecilenYazarId;
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(txt_KitapAdi.Text) ||
                    string.IsNullOrWhiteSpace(txt_Yazar.Text) ||
                    string.IsNullOrWhiteSpace(txt_SayfaSayisi.Text) ||
                    string.IsNullOrWhiteSpace(txt_ISBN.Text) ||
                    cb_Yayinevi.SelectedValue == null ||
                    cb_Tur.SelectedValue == null ||
                    cb_Kategori.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int yayineviId;
                if (cb_Yayinevi.SelectedValue == null || !int.TryParse(cb_Yayinevi.SelectedValue.ToString(), out yayineviId))
                {
                    MessageBox.Show("Geçerli bir yayınevi seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int turId;
                if (cb_Tur.SelectedValue == null || !int.TryParse(cb_Tur.SelectedValue.ToString(), out turId))
                {
                    MessageBox.Show("Geçerli bir tür seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kategoriId;
                if (cb_Kategori.SelectedValue == null || !int.TryParse(cb_Kategori.SelectedValue.ToString(), out kategoriId))
                {
                    MessageBox.Show("Geçerli bir kategori seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Yazar ID'sini kontrol et
                if (seciliYazarId == 0)
                {
                    MessageBox.Show("Geçerli bir yazar seçmelisiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kitap nesnesini oluştur
                Kitap kitap = new Kitap
                {
                    ID = seciliKitapId,  // Eğer sıfırdan büyükse güncelleme yapılacak
                    KitapAdi = txt_KitapAdi.Text.Trim(),
                    YazarID = seciliYazarId,
                    YazarAdi = txt_Yazar.Text.Trim(),
                    YayineviID = yayineviId,
                    YayineviAdi = cb_Yayinevi.Text.Trim(),
                    TurID = turId,
                    TurAdi = cb_Tur.Text.Trim(),
                    KategoriID = kategoriId,
                    KategoriAdi = cb_Kategori.Text.Trim(),
                    SayfaSayisi = txt_SayfaSayisi.Text.Trim(),
                    ISBN = txt_ISBN.Text.Trim(),
                    RafNumarasi = txt_RafNumarasi.Text.Trim(),
                    Aciklama = txt_Aciklama.Text.Trim()
                };

                // Güncelleme veya Ekleme işlemi
                bool isSuccess = kitapBL.KitapEkle(kitap);

                // İşlem sonucuna göre mesaj göster
                if (isSuccess)
                {
                    MessageBox.Show(seciliKitapId > 0 ? "Kitap başarıyla güncellendi." : "Kitap başarıyla eklendi.",
                                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Listeyi güncelle ve formu temizle
                ListeyiYenile();
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}\n\nHata Detayları:\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void FormuTemizle()
        {
            txt_KitapAdi.Clear();
            txt_Yazar.Clear();
            txt_SayfaSayisi.Clear();
            txt_ISBN.Clear();
            txt_RafNumarasi.Clear();
            txt_Aciklama.Clear();

            cb_Yayinevi.SelectedIndex = -1;
            cb_Tur.SelectedIndex = -1;
            cb_Kategori.SelectedIndex = -1;

            seciliKitapId = 0;
            seciliYazarId = 0;
        }

        private void YeniKitapKayitForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            ComboBoxlarıDoldur();
        }

        private void ListeyiYenile()
        {
            try
            {
                List<Kitap> kitapListesi = kitapBL.TumKitaplariGetir();
                dgv_KitapListesi.DataSource = new BindingList<Kitap>(kitapListesi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_KitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_KitapListesi.Rows[e.RowIndex];

                seciliKitapId = Convert.ToInt32(row.Cells["ID"].Value);
                txt_KitapAdi.Text = row.Cells["KitapAdi"].Value.ToString();
                txt_Yazar.Text = row.Cells["YazarAdi"].Value.ToString();
                seciliYazarId = Convert.ToInt32(row.Cells["YazarID"].Value);

                // Yayinevi combobox'ını seçmek için
                int yayineviId = Convert.ToInt32(row.Cells["YayineviID"].Value);
                cb_Yayinevi.SelectedValue = yayineviId;

                // Tür combobox'ını seçmek için
                int turId = Convert.ToInt32(row.Cells["TurID"].Value);
                cb_Tur.SelectedValue = turId;

                // Kategori combobox'ını seçmek için
                int kategoriId = Convert.ToInt32(row.Cells["KategoriID"].Value);
                cb_Kategori.SelectedValue = kategoriId;

                // Diğer alanlar
                txt_SayfaSayisi.Text = row.Cells["SayfaSayisi"].Value.ToString();
                txt_ISBN.Text = row.Cells["ISBN"].Value.ToString();
                txt_RafNumarasi.Text = row.Cells["RafNumarasi"].Value.ToString();
                txt_Aciklama.Text = row.Cells["Aciklama"].Value.ToString();
            }
        }
        private void ComboBoxlarıDoldur()
        {
            try
            {
                // Yayın evlerini yükle
                var yayinevleri = yayineviBL.TumYayinevleriniGetir();
                cb_Yayinevi.DisplayMember = "YayineviAdi"; // Görünen değer
                cb_Yayinevi.ValueMember = "id"; // Seçildiğinde alınacak değer
                cb_Yayinevi.DataSource = yayinevleri;
                cb_Yayinevi.SelectedIndex = -1; // Başlangıçta hiçbiri seçili olmasın

                // Kategorileri yükle
                var kategoriler = katRafBL.TumKategoriRaflariGetir();
                cb_Kategori.DisplayMember = "KategoriAdi";
                cb_Kategori.ValueMember = "id";
                cb_Kategori.DataSource = kategoriler;
                cb_Kategori.SelectedIndex = -1; // Başlangıçta hiçbiri seçili olmasın

                // Kitap türlerini yükle
                var kitapTurleri = turBL.TumTurleriGetir();
                cb_Tur.DisplayMember = "TurAdi";
                cb_Tur.ValueMember = "id";
                cb_Tur.DataSource = kitapTurleri;
                cb_Tur.SelectedIndex = -1; // Başlangıçta hiçbiri seçili olmasın
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçili kitap ID'sinin olup olmadığını kontrol et
                if (seciliKitapId <= 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz bir kitabı seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kullanıcıdan onay al
                DialogResult dialogResult = MessageBox.Show("Seçilen kitabı silmek istediğinizden emin misiniz?",
                                                            "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Eğer kullanıcı 'Evet' diyorsa, kitap silinir
                if (dialogResult == DialogResult.Yes)
                {
                    // Kitap silme işlemi
                    bool isSuccess = kitapBL.KitapSil(seciliKitapId);

                    // İşlem sonucuna göre mesaj göster
                    if (isSuccess)
                    {
                        MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListeyiYenile();  // Listeyi güncelle
                        FormuTemizle();   // Formu temizle
                    }
                    else
                    {
                        MessageBox.Show("Kitap silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}