using BusinessLayer;
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

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class YeniKitapKayitForm : Form
    {
        private KitapBL kitapBL;
        private int seciliKitapId = 0;
        public YeniKitapKayitForm()
        {
            InitializeComponent();
            kitapBL = new KitapBL();

        }
        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            YazarAraPopupForm yazarAraPopupForm = new YazarAraPopupForm();
            yazarAraPopupForm.Show();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan verileri doğrudan entity katmanındaki modele atıyoruz
                Kitap yeniKitap = new Kitap
                {
                    KitapAdi = txt_KitapAdi.Text?.Trim(), // Kitap adı
                    YazarID = Convert.ToInt32(txt_Yazar.Text?.Trim()), // Yazar ID'si
                    YayineviID = Convert.ToInt32(cb_Yayinevi.SelectedValue), // Yayinevi ID'si
                    KitapTuruID = Convert.ToInt32(cb_Tur.SelectedValue), // Kitap Türü ID'si
                    KategoriID = Convert.ToInt32(cb_Kategori.SelectedValue), // Kategori ID'si
                    SayfaSayisi = txt_SayfaSayisi.Text?.Trim(),  // Sayfa sayısı (string olarak alıyoruz)
                    ISBN = txt_ISBN.Text?.Trim() // ISBN
                };

                // Sayfa sayısını kontrol et
                string sayfaSayisiStr = txt_SayfaSayisi.Text.Trim(); // Sayfa sayısı
                bool isSayfaSayisiValid = int.TryParse(sayfaSayisiStr, out _);

                // Eğer sayfa sayısı geçerli değilse, kullanıcıyı uyar
                if (!isSayfaSayisiValid)
                {
                    MessageBox.Show("Sayfa sayısı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Geçerli bir sayfa sayısı girilmediği için fonksiyon sonlandırılır
                }

                // Kitap ekleme işlemi (KitapEkle methodu bool döner)
                bool isAdded = kitapBL.KitapEkle(yeniKitap);

                // Kitap ekleme sonucunu kullanıcıya göster
                string sonuc;
                if (isAdded)
                {
                    sonuc = "Kitap başarıyla eklendi.";
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();  // Listeyi yenile
                }
                else
                {
                    sonuc = "Kitap eklenirken bir hata oluştu.";
                    MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void FormTemizle()
        {
            txt_KitapAdi.Clear();
            txt_SayfaSayisi.Clear();
            txt_ISBN.Clear();
            txt_Yazar.Clear();
            cb_Kategori.Items.Clear();
            cb_Tur.Items.Clear();
            cb_Yayinevi.Items.Clear();
            seciliKitapId = 0;  // Yeni kayıt moduna geç
            btn_Kaydet.Text = "Kaydet";
            dgv_KitapListesi.ClearSelection();
            txt_KitapAdi.Focus();
        }

        private void ComboBoxlarıDoldur()
        {
            try
            {
                // Assuming you have methods to get these lists from the database or predefined lists
                var yayinevleri = kitapBL.GetAllYayineviAdlari(); // Retrieve list from your business layer
                var kategoriler = kitapBL.GetAllKategoriAdlari(); // Retrieve list from your business layer
                var kitapTurleri = kitapBL.GetAllTurAdlari(); // Retrieve list from your business layer

                // Populate ComboBox with these values
                cb_Yayinevi.DataSource = yayinevleri;
                cb_Yayinevi.DisplayMember = "YayineviAdi";  // Assuming the entity has this property

                cb_Kategori.DataSource = kategoriler;
                cb_Kategori.DisplayMember = "KategoriAdi";  // Assuming the entity has this property

                cb_Tur.DataSource = kitapTurleri;
                cb_Tur.DisplayMember = "KitapTuruAdi";  // Assuming the entity has this property
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
