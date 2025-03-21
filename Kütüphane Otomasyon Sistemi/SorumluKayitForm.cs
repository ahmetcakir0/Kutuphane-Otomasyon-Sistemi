using BusinessLayer;
using DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using EntityLayer;
using System.Text.RegularExpressions;// Sorumlu sınıfı burada bulunuyor

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class SorumluKayitForm : Form
    {
        private readonly SorumluBL sorumluBL;
        private int seciliSorumluId = 0;  // Seçili kaydın ID'si; 0 ise yeni kayıt ekleme
        public SorumluKayitForm()
        {
            InitializeComponent();
            sorumluBL = new SorumluBL();
        }

        private void SorumluKayitForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void FormTemizle()
        {
            txt_SorumluAd.Clear();
            txt_SorumluSoyad.Clear();
            txt_TCKimlik.Clear();
            txt_Rol.Clear();
            txt_TelNo.Clear();
            txt_Eposta.Clear();
            txt_Adres.Clear();
            txt_SorumluKullaniciAdi.Clear();
            txt_SorumluSifre.Clear();
            dt_DogumTarihi.Value = DateTime.Now;
            seciliSorumluId = 0;  // Yeni kayıt moduna geç
            dgv_SorumluListesi.ClearSelection();
            txt_SorumluAd.Focus();
        }
        private bool EpostaGecerliMi(string eposta)
        {
            if (string.IsNullOrWhiteSpace(eposta))
                return false;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(eposta, pattern);
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kayıt bilgilerinin alındığı kısımlar
                string sorumluAdi = txt_SorumluAd.Text.Trim();
                string sorumluSoyadi = txt_SorumluSoyad.Text.Trim();
                string tcKimlik = txt_TCKimlik.Text.Trim();
                string rol = txt_Rol.Text.Trim();
                string telNo = txt_TelNo.Text.Trim();
                string ePosta = txt_Eposta.Text.Trim();
                DateTime dogumTarihi = dt_DogumTarihi.Value;
                string adres = txt_Adres.Text.Trim();
                string kullaniciAdi = txt_SorumluKullaniciAdi.Text.Trim();
                string sifre = txt_SorumluSifre.Text.Trim();

                string sonuc = string.Empty;
                if (!EpostaGecerliMi(ePosta))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Eğer güncelleme yapılıyorsa (seciliSorumluId > 0), TC Kimlik No, Kullanıcı Adı, Telefon Numarası ve E-Posta adresi kontrolü yapılmaz
                if (seciliSorumluId == 0)
                {
                    // Yeni kayıt eklerken bu kontrolleri yap
                    if (sorumluBL.TCKimlikVarMi(tcKimlik))
                    {
                        MessageBox.Show("Bu TC Kimlik numarası zaten kullanılıyor. Lütfen farklı bir numara girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sorumluBL.KullaniciAdiVarMi(kullaniciAdi))
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen farklı bir kullanıcı adı girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sorumluBL.TelefonNoVarMi(telNo))
                    {
                        MessageBox.Show("Bu telefon numarası zaten kullanılıyor. Lütfen farklı bir numara girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (sorumluBL.EpostaVarMi(ePosta))
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kullanılıyor. Lütfen farklı bir adres girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Eğer seciliSorumluId 0'dan büyükse güncelleme yapıyoruz, aksi halde yeni kayıt ekliyoruz.
                if (seciliSorumluId > 0)
                {
                    // Güncelleme işlemi
                    Sorumlu guncellenenSorumlu = new Sorumlu(seciliSorumluId, sorumluAdi, sorumluSoyadi, tcKimlik, rol, telNo, ePosta, dogumTarihi, adres, kullaniciAdi, sifre);
                    sonuc = sorumluBL.SorumluGuncelle(guncellenenSorumlu);
                }
                else
                {
                    // Yeni kayıt ekleme işlemi
                    Sorumlu yeniSorumlu = new Sorumlu(0, sorumluAdi, sorumluSoyadi, tcKimlik, rol, telNo, ePosta, dogumTarihi, adres, kullaniciAdi, sifre);
                    sonuc = sorumluBL.SorumluEkle(yeniSorumlu);
                }

                if (sonuc == "Sorumlu başarıyla eklendi." || sonuc == "Sorumlu başarıyla güncellendi.")
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

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (seciliSorumluId == 0) // Eğer seçili sorumlu ID'si 0 ise hata mesajı göster
            {
                MessageBox.Show("Lütfen bir sorumlu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçilen sorumluyu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (sorumluBL.SorumluSil(seciliSorumluId))  // Seçilen sorumluyu sil
                {
                    MessageBox.Show("Sorumlu başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                }
                else
                {
                    MessageBox.Show("Sorumlu silinirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListeyiYenile()
        {
            try
            {
                DataTable sorumluTablosu = sorumluBL.TumSorumlulariGetir();
                dgv_SorumluListesi.DataSource = sorumluTablosu;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_SorumluListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Başlık satırına tıklanmadığından emin olun
            {
                // Seçilen satırın bilgilerini al
                DataGridViewRow row = dgv_SorumluListesi.Rows[e.RowIndex];

                seciliSorumluId = Convert.ToInt32(row.Cells["ID"].Value);
                txt_SorumluAd.Text = row.Cells["SorumluAdi"].Value.ToString();
                txt_SorumluSoyad.Text = row.Cells["SorumluSoyadi"].Value.ToString();
                txt_TCKimlik.Text = row.Cells["TCKimlik"].Value.ToString();
                txt_Rol.Text = row.Cells["Rol"].Value.ToString();
                txt_TelNo.Text = row.Cells["TelNo"].Value.ToString();
                txt_Eposta.Text = row.Cells["Eposta"].Value.ToString();
                txt_Adres.Text = row.Cells["Adres"].Value.ToString();
                txt_SorumluKullaniciAdi.Text = row.Cells["KullaniciAdi"].Value.ToString();
                txt_SorumluSifre.Text = row.Cells["Sifre"].Value.ToString();
                dt_DogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);

                // Burada, seçili satırın ID'si doğru şekilde alınıyor
            }
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

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }

        private void txt_TelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir rakam değilse, karakteri engelle
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 = Backspace
            {
                e.Handled = true; // Karakteri engelle
            }
        }

        private void dgv_SorumluListesi_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_SorumluListesi.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void txt_SorumluAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ') // 8 = Backspace, ' ' = Boşluk
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }
        }

        private void txt_SorumluSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ') // 8 = Backspace, ' ' = Boşluk
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }
        }
    }
}
