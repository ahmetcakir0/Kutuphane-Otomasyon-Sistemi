using BusinessLayer;
using DataAccessLayer;
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
                string yazarAdiSoyadi = txt_YazarAdSoyad.Text.Trim();
                string iletisim = txt_Iletisim.Text.Trim();
                DateTime dogumTarihi = dtp_DogumTarihi.Value;
                string biyografi = txt_Biyografi.Text.Trim();

                // Tür ekleme işlemi
                string sonuc = yazarBL.YazarEkle(yazarAdiSoyadi, iletisim, dogumTarihi, biyografi);

                if (sonuc == "Yazar başarıyla eklendi.")
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

            //try
            //{
            //    string adisoyadi = txt_YazarAdSoyad.Text.Trim();
            //    string iletisim = txt_Iletisim.Text.Trim();
            //    string biyografi = txt_Biyografi.Text.Trim();
            //    DateTime dogumTarihi = dtp_DogumTarihi.Value;

            //    // Yazar ekleme işlemi
            //    string sonuc = yazarBL.YazarEkle(adisoyadi, iletisim, dogumTarihi, biyografi);

            //    if (sonuc == "Yazar başarıyla eklendi.")
            //    {
            //        MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ListeyiYenile();
            //        FormTemizle();
            //    }
            //    else
            //    {
            //        MessageBox.Show(sonuc, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_YazarListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek yazarı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgv_YazarListesi.SelectedRows[0].Cells["ID"].Value);
                string yazarAdiSoyadi = txt_YazarAdSoyad.Text.Trim();
                string iletisim = txt_Iletisim.Text.Trim();
                DateTime dogumTarihi = dtp_DogumTarihi.Value;
                string biyografi = txt_Biyografi.Text.Trim();
                
                string sonuc = yazarBL.YazarGuncelle(id, yazarAdiSoyadi, iletisim, dogumTarihi, biyografi);

                if (sonuc == "Yazar başarıyla güncellendi.")
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
                var yazarlarTablosu = yazarBL.TumYazarlariGetir();

                // Veriyi DataGridView'e atıyoruz
                dgv_YazarListesi.DataSource = yazarlarTablosu;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
