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
        public YeniKitapKayitForm()
        {
            InitializeComponent();
            kitapBL = new KitapBL();

        }
        private void KitaplariYukle()
        {
            dgv_KitapListesi.DataSource = kitapBL.TumKitaplariGetir();
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
                Kitap yeniKitap = new Kitap
                {
                    KitapAdi = txt_KitapAdi.Text,
                    YazarID = Convert.ToInt32(txt_Yazar.Text),
                    YayineviID = Convert.ToInt32(cb_Yayinevi.SelectedValue),
                    KitapTuruID = Convert.ToInt32(cb_Tur.SelectedValue),
                    KategoriID = Convert.ToInt32(cb_Kategori.SelectedValue),
                    SayfaSayisi = Convert.ToInt32(txt_SayfaSayisi.Text),
                };

                if (kitapBL.KitapEkle(yeniKitap))
                {
                    MessageBox.Show("Kitap başarıyla eklendi.");
                    KitaplariYukle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void YeniKitapKayitForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
            ComboBoxlarıDoldur();
        }

        private void ComboBoxlarıDoldur()
        {
            try
            {
                // Assuming you have methods to get these lists from the database or predefined lists
                var yayinEvleri = kitapBL.yay(); // Retrieve list from your business layer
                var kategoriler = kitapBL.GetKategoriListesi(); // Retrieve list from your business layer
                var kitapTurleri = kitapBL.GetKitapTuruListesi(); // Retrieve list from your business layer

                // Populate ComboBox with these values
                cmb_Yayinevi.DataSource = yayinEvleri;
                cmb_Yayinevi.DisplayMember = "YayineviAdi";  // Assuming the entity has this property

                cmb_Kategori.DataSource = kategoriler;
                cmb_Kategori.DisplayMember = "KategoriAdi";  // Assuming the entity has this property

                cmb_KitapTuru.DataSource = kitapTurleri;
                cmb_KitapTuru.DisplayMember = "KitapTuruAdi";  // Assuming the entity has this property
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
