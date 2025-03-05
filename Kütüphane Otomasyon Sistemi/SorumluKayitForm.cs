using BusinessLayer;
using DataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;
using EntityLayer;  // Sorumlu sınıfı burada bulunuyor

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
            btn_Kaydet.Text = "Kaydet";
            dgv_SorumluListesi.ClearSelection();
            txt_SorumluAd.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
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

                // Eğer seciliSorumluId 0'dan büyükse güncelleme yapıyoruz, aksi halde yeni kayıt ekliyoruz.
                if (seciliSorumluId > 0)
                {
                    Sorumlu guncellenenSorumlu = new Sorumlu(seciliSorumluId, sorumluAdi, sorumluSoyadi, tcKimlik, rol, telNo, ePosta, dogumTarihi, adres, kullaniciAdi, sifre);
                    sonuc = sorumluBL.SorumluGuncelle(guncellenenSorumlu);
                }
                else
                {
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
            if (dgv_SorumluListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir sorumlu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Seçilen sorumluyu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv_SorumluListesi.SelectedRows)
                {
                    int sorumluID = Convert.ToInt32(row.Cells["ID"].Value);
                    if (sorumluBL.SorumluSil(sorumluID))
                    {
                        MessageBox.Show("Sorumlu başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sorumlu silinirken hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                ListeyiYenile();
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
                DataGridViewRow row = dgv_SorumluListesi.Rows[e.RowIndex];

                // Seçili satırdaki verileri TextBox'lara aktar
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

                // Seçim yapıldığında buton metnini güncelleme olarak değiştir
                btn_Kaydet.Text = "Güncelle";
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
        }
    }
}
