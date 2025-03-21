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
            FormTemizle();
            ListeyiYenile();

            dgv_UyeListesi.ClearSelection();
            dgv_UyeListesi.CurrentCell = null;
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
            dgv_UyeListesi.ClearSelection();
        }

        private void Kaydet_Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni bir Üye nesnesi oluşturuluyor
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

                // Eğer formda hiçbir bilgi yoksa, işlem yapılmıyor
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

                // Eğer herhangi bir satır seçili değilse, yeni üye ekleniyor
                if (dgv_UyeListesi.SelectedRows.Count == 0)
                {
                    // Yeni üye eklerken, TC Kimlik, Telefon ve E-Posta bilgisi kontrol ediliyor
                    if (uyeBL.UyeBilgisiVarMi(uye.TCKimlik, uye.TelNo, uye.Eposta, 0)) // 0 yeni kayıt anlamına gelir
                    {
                        MessageBox.Show("Bu TC Kimlik, Telefon veya E-Posta başka bir üye tarafından kullanılıyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    sonuc = uyeBL.UyeEkle(uye); // Yeni üyeyi ekle
                }
                else // Eğer satır seçildiyse, üye güncelleniyor
                {
                    if (int.TryParse(dgv_UyeListesi.SelectedRows[0].Cells["ID"].Value?.ToString(), out int id))
                    {
                        uye.ID = id; // Seçilen üyeye ait ID'yi güncelleme için ayarla
                        sonuc = uyeBL.UyeGuncelle(uye); // Üyeyi güncelle
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz üye ID'si bulundu, lütfen tekrar seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Sonuç mesajını kullanıcıya göster
                MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile ve formu temizle
                ListeyiYenile();
                FormTemizle();
            }
            catch (Exception ex)
            {
                // Hata oluşursa, hata mesajı göster
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

        private void txt_TCKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kullanıcının sadece rakam girmesini sağlayalım (sayısal değer)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8, Backspace tuşu
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }

            // TC Kimlik numarasının 11 karakteri geçmemesini sağlayalım
            if (txt_TCKimlik.Text.Length >= 11 && e.KeyChar != 8) // 11. karakterden sonrası engellenir
            {
                e.Handled = true; // Karakter girişini engelle
            }
        }

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) // 8 = Backspace
            {
                e.Handled = true;  // Eğer karakter harf değilse, girmeyi engelle
            }
        }

        private void txt_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) // 8 = Backspace
            {
                e.Handled = true;  // Eğer karakter harf değilse, girmeyi engelle
            }
        }

        private void txt_TelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 = Backspace
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void dgv_UyeListesi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_UyeListesi.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
    }
}
