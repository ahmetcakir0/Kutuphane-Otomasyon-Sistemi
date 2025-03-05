using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
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

    public partial class UyeKayitForm : Form
    {
        private readonly UyeBL uyeBL;

        public UyeKayitForm()
        {
            InitializeComponent();
            uyeBL = new UyeBL();
        }

        private void YeniUyeKayitForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void FormTemizle()
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_TCKimlik.Clear();
            txt_TelNo.Clear();
            txt_Eposta.Clear();
            txt_Adres.Clear();
            txt_Ad.Focus();
        }

        private void Kaydet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Üye nesnesi oluşturuluyor
                Uye uye = new Uye
                {
                    Ad = txt_Ad.Text?.Trim(),
                    Soyad = txt_Soyad.Text?.Trim(),
                    TCKimlik = txt_TCKimlik.Text?.Trim(),
                    TelNo = txt_TelNo.Text?.Trim(),
                    Eposta = txt_Eposta.Text?.Trim(),
                    DogumTarihi = dtp_DogumTarihi.Value,
                    Adres = txt_Adres.Text?.Trim()
                };

                // Eğer form tamamen boşsa işlem yapma
                if (string.IsNullOrWhiteSpace(uye.Ad) &&
                    string.IsNullOrWhiteSpace(uye.Soyad) &&
                    string.IsNullOrWhiteSpace(uye.TCKimlik) &&
                    string.IsNullOrWhiteSpace(uye.TelNo) &&
                    string.IsNullOrWhiteSpace(uye.Eposta) &&
                    string.IsNullOrWhiteSpace(uye.Adres))
                {
                    MessageBox.Show("Lütfen geçerli bir üye bilgisi girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sonuc;

                // Eğer DataGridView'de bir satır seçiliyse, güncelleme yapılmalı
                if (dgv_UyeListesi.SelectedRows.Count > 0)
                {
                    if (int.TryParse(dgv_UyeListesi.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                    {
                        uye.ID = id; // Güncelleme işlemi için ID'yi ayarlıyoruz
                        sonuc = uyeBL.UyeGuncelle(uye);
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz üye ID'si bulundu, lütfen tekrar seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else // Eğer seçili satır yoksa yeni kayıt eklenmeli
                {
                    sonuc = uyeBL.UyeEkle(uye);
                }

                // İşlem sonucunu kullanıcıya göster
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile ve formu temizle
                ListeyiYenile();
                FormTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle_Button_Click(object sender, EventArgs e)
        {
            if (dgv_UyeListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek üyeyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(dgv_UyeListesi.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                {
                    MessageBox.Show("Geçersiz üye ID'si bulundu, lütfen tekrar seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Uye uye = new Uye
                {
                    ID = id,
                    Ad = txt_Ad.Text?.Trim(),
                    Soyad = txt_Soyad.Text?.Trim(),
                    TCKimlik = txt_TCKimlik.Text?.Trim(),
                    TelNo = txt_TelNo.Text?.Trim(),
                    Eposta = txt_Eposta.Text?.Trim(),
                    DogumTarihi = dtp_DogumTarihi.Value,
                    Adres = txt_Adres.Text?.Trim()
                };

                string sonuc = uyeBL.UyeGuncelle(uye);

                MessageBoxIcon icon = (sonuc == "Üye başarıyla güncellendi.") ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, icon);

                if (sonuc == "Üye başarıyla güncellendi.")
                {
                    ListeyiYenile();
                    FormTemizle();
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
                var uyelerTablosu = uyeBL.TumUyeleriGetir();

                dgv_UyeListesi.DataSource = uyelerTablosu;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_UyeListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kayıt seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçilen üyeyi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv_UyeListesi.SelectedRows)
                {
                    int uyeID = Convert.ToInt32(row.Cells["ID"].Value);
                    UyeDAL uyeDal = new UyeDAL();

                    if (uyeDal.UyeSil(uyeID))
                    {
                        MessageBox.Show("Üye başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Üye silinirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // **Silme sonrası listeyi yenile**
                dgv_UyeListesi.DataSource = new UyeDAL().TumUyeleriGetir();
            }
        }

        private void dgv_UyeListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_UyeListesi.Rows[e.RowIndex];

                txt_TCKimlik.Text = row.Cells["TCKimlik"].Value.ToString();
                txt_Ad.Text = row.Cells["Ad"].Value.ToString();
                txt_Soyad.Text = row.Cells["Soyad"].Value.ToString();
                txt_TelNo.Text = row.Cells["TelNo"].Value.ToString();
                txt_Eposta.Text = row.Cells["Eposta"].Value.ToString();
                txt_Adres.Text = row.Cells["Adres"].Value.ToString();
                dtp_DogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
            }
        }
        private int seciliUyeId = 0;
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_TelNo.Clear();
            txt_Eposta.Clear();
            txt_TCKimlik.Clear();
            txt_Adres.Clear();
            dtp_DogumTarihi.Value = DateTime.Now;

            seciliUyeId = 0; // Seçili yazar sıfırlanır
            dgv_UyeListesi.ClearSelection(); // Seçimi kaldır
        }
    }
}
