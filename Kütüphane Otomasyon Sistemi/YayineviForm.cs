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

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class YayineviForm : Form
    {
        private readonly YayineviBL yayineviBL;
        public YayineviForm()
        {
            InitializeComponent();
            yayineviBL = new YayineviBL();
        }

        private void YayineviForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }
        private void FormTemizle()
        {
            txt_Yayinevi.Clear();
            txt_TelNo.Clear();
            txt_Eposta.Clear();
            txt_Adres.Clear();
            txt_Yayinevi.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string yayineviAdi = txt_Yayinevi.Text.Trim();
                string telNo = txt_TelNo.Text.Trim();
                string ePosta = txt_Eposta.Text.Trim();
                string adres = txt_Adres.Text.Trim();

                string sonuc = yayineviBL.YayineviEkle(yayineviAdi, telNo, ePosta, adres);

                if (sonuc == "Yayinevi başarıyla eklendi.")
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
            if (dgv_YayıneviListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek yayınevini seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgv_YayıneviListesi.SelectedRows[0].Cells["ID"].Value);
                string yayineviAdi = txt_Yayinevi.Text.Trim();
                string telNo = txt_TelNo.Text.Trim();
                string ePosta = txt_Eposta.Text.Trim();
                string adres = txt_Adres.Text.Trim();

                string sonuc = yayineviBL.YayineviGuncelle(id, yayineviAdi, telNo, ePosta, adres);

                if (sonuc == "Yayınevi başarıyla güncellendi.")
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
                var yayineviTablosu = yayineviBL.TumYayinevleriniGetir();

                // Veriyi DataGridView'e atıyoruz
                dgv_YayıneviListesi.DataSource = yayineviTablosu;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
