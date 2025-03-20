using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class YayineviForm : Form
    {
        private readonly YayineviBL yayineviBL;
        private int seciliYayineviId = 0;

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
            seciliYayineviId = 0;
            dgv_YayıneviListesi.ClearSelection();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string yayineviAdi = txt_Yayinevi.Text.Trim();
                string telNo = txt_TelNo.Text.Trim();
                string ePosta = txt_Eposta.Text.Trim();
                string adres = txt_Adres.Text.Trim();

                // Eğer form tamamen boşsa işlem yapma
                if (string.IsNullOrWhiteSpace(yayineviAdi) ||
                    string.IsNullOrWhiteSpace(telNo) ||
                    string.IsNullOrWhiteSpace(ePosta) ||
                    string.IsNullOrWhiteSpace(adres))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sonuc;

                // Eğer yeni kayıt ekleniyorsa (seciliYayineviId 0'dan küçükse), telefon numarası ve e-posta kontrolü yapılacak
                if (seciliYayineviId == 0) // Yeni kayıt ekleniyorsa
                {
                    // Telefon numarası ve e-posta var mı kontrol et
                    if (yayineviBL.TelNoVarMi(telNo))  // Eğer telefon numarası zaten varsa
                    {
                        MessageBox.Show("Bu telefon numarası zaten kullanımda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (yayineviBL.EpostaVarMi(ePosta))  // Eğer e-posta zaten varsa
                    {
                        MessageBox.Show("Bu e-posta adresi zaten kullanımda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Yeni ekleme mi yoksa güncelleme mi yapılacak?
                if (seciliYayineviId > 0) // **Eğer ID varsa güncelleme işlemi**
                {
                    Yayinevi yayinevi = new Yayinevi
                    {
                        id = seciliYayineviId, // Güncellenecek olan ID
                        YayineviAdi = yayineviAdi,
                        TelNo = telNo,
                        Eposta = ePosta,
                        Adres = adres
                    };

                    sonuc = yayineviBL.YayineviGuncelle(yayinevi);
                }
                else // **Yeni ekleme işlemi**
                {
                    Yayinevi yayinevi = new Yayinevi
                    {
                        YayineviAdi = yayineviAdi,
                        TelNo = telNo,
                        Eposta = ePosta,
                        Adres = adres
                    };

                    sonuc = yayineviBL.YayineviEkle(yayinevi);
                }

                if (sonuc.Contains("başarıyla")) // Başarılı işlem
                {
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiYenile();
                    FormTemizle();
                }
                else // Hata veya uyarı mesajı
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
                var yayineviListesi = yayineviBL.TumYayinevleriniGetir();
                dgv_YayıneviListesi.DataSource = null;
                dgv_YayıneviListesi.DataSource = yayineviListesi;

                // DataGridView'in kolon başlıklarını düzenleme
                dgv_YayıneviListesi.Columns["id"].HeaderText = "ID";
                dgv_YayıneviListesi.Columns["YayineviAdi"].HeaderText = "Yayınevi Adı";
                dgv_YayıneviListesi.Columns["TelNo"].HeaderText = "Telefon";
                dgv_YayıneviListesi.Columns["Eposta"].HeaderText = "E-Posta";
                dgv_YayıneviListesi.Columns["Adres"].HeaderText = "Adres";

                dgv_YayıneviListesi.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_YayıneviListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_YayıneviListesi.Rows[e.RowIndex].Cells["id"].Value != null)
            {
                DataGridViewRow row = dgv_YayıneviListesi.Rows[e.RowIndex];

                seciliYayineviId = Convert.ToInt32(row.Cells["id"].Value);
                txt_Yayinevi.Text = row.Cells["YayineviAdi"].Value.ToString();
                txt_TelNo.Text = row.Cells["TelNo"].Value.ToString();
                txt_Eposta.Text = row.Cells["Eposta"].Value.ToString();
                txt_Adres.Text = row.Cells["Adres"].Value.ToString();
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            FormTemizle();
            dgv_YayıneviListesi.ClearSelection();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (seciliYayineviId == 0)
            {
                MessageBox.Show("Lütfen silmek için bir yayınevi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult sonuc = MessageBox.Show("Seçili yayınevini silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                string mesaj = yayineviBL.YayineviSil(seciliYayineviId);
                MessageBox.Show(mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mesaj.Contains("başarıyla"))
                {
                    ListeyiYenile();
                    FormTemizle();
                }
            }
        }

        private void dgv_YayıneviListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Eğer başlık satırına tıklanmadıysa
            {
                DataGridViewRow row = dgv_YayıneviListesi.Rows[e.RowIndex];

                // Seçili Yayınevi'nin ID'sini al
                if (row.Cells["id"].Value != null)
                {
                    seciliYayineviId = Convert.ToInt32(row.Cells["id"].Value);
                }

                // Seçili satırdaki verileri ilgili alanlara aktar
                txt_Yayinevi.Text = row.Cells["YayineviAdi"].Value?.ToString();
                txt_TelNo.Text = row.Cells["TelNo"].Value?.ToString();
                txt_Eposta.Text = row.Cells["Eposta"].Value?.ToString();
                txt_Adres.Text = row.Cells["Adres"].Value?.ToString();
            }
        }

        private void txt_TelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bu tuşun girmesini engelle
            }
        }
    }
}
