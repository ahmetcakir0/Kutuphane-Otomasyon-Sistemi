using DataAccessLayer;
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
using BusinessLayer;
using System.Security.Policy;

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class KategoriRaflarForm : Form
    {
        private readonly KatRafBL katRafBL;

        public KategoriRaflarForm()
        {
            InitializeComponent();
            katRafBL = new KatRafBL();
        }

        private void KategoriRaflarForm_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        private void FormTemizle()
        {
            // Formdaki inputları temizleyelim
            txt_KategoriAdi.Clear();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string kategoriAdi = txt_KategoriAdi.Text.Trim();


                string sonuc = katRafBL.KategoriEkle(kategoriAdi);

                if (sonuc == "Kategori başarıyla eklendi.")
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
            if (dgv_KategoriRaflar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kategori seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Seçilen satırdaki ID'yi alalım
                int id = Convert.ToInt32(dgv_KategoriRaflar.SelectedRows[0].Cells["ID"].Value);
                string kategoriAdi = txt_KategoriAdi.Text.Trim();

                // Tür güncelleme işlemi
                string sonuc = katRafBL.KategoriGuncelle(id, kategoriAdi);

                if (sonuc == "Kategoriyi başarıyla güncellendi.")
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
                var turlerTablosu = katRafBL.TumKategoriRaflariGetir();

                // Veriyi DataGridView'e atıyoruz
                dgv_KategoriRaflar.DataSource = turlerTablosu;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Liste yenileme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_KategoriRaflar.SelectedRows.Count == 0)
            {
                // Eğer hiç satır seçilmediyse, kullanıcıya uyarı mesajı göster
                MessageBox.Show("Lütfen bir kayıt seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Seçilen kaydı silmek istediğinize emin misiniz?",
                                                      "Silme Onayı",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Silme işlemini gerçekleştir
                    foreach (DataGridViewRow row in dgv_KategoriRaflar.SelectedRows)
                    {
                        // Burada, seçilen satırı veri kaynağınızdan silme işlemi yapılmalı
                        dgv_KategoriRaflar.Rows.RemoveAt(row.Index);
                    }
                }
            }
        }

        private void btn_Temizleme_Click(object sender, EventArgs e)
        {
            txt_KategoriAdi.Clear();
        }



        private void txt_KategoriAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8) // 8 = Backspace
            {
                e.Handled = true;  // Eğer karakter harf değilse, girmeyi engelle
            }
        }

        private void dgv_KategoriRaflar_Click(object sender, EventArgs e)
        {
            if (dgv_KategoriRaflar.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki "KategoriAdi" hücresinin değerini alıp TextBox'a aktar
                txt_KategoriAdi.Text = dgv_KategoriRaflar.SelectedRows[0].Cells["KategoriAdi"].Value.ToString();
            }
        }

        private void dgv_KategoriRaflar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_KategoriRaflar.Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.NotSortable;

        }
    }
}
