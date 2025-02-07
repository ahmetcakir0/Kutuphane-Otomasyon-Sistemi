using BusinessLayer;
using EntityLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class YeniKitapKayitForm : Form
    {
        private readonly KitapBL kitapBL;
        private readonly string connectionString;

        public YeniKitapKayitForm()
        {
            InitializeComponent();
            connectionString = "Server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
            kitapBL = new KitapBL(connectionString);
        }

        private void YeniKitapKayitForm_Load(object sender, EventArgs e)
        {
            try
            {
    
                DoldurComboBox("SELECT ID, YayineviAdi FROM Yayinevleri", cb_Yayinevi, "YayineviAdi", "ID");
                DoldurComboBox("SELECT ID, TurAdi FROM Turler", cb_KitapTuru, "TurAdi", "ID");
                DoldurComboBox("SELECT ID, KategoriAdi FROM Kategoriler", cb_Kategori, "KategoriAdi", "ID");
                KitaplariDataGridViewGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoldurComboBox(string query, ComboBox comboBox, string displayMember, string valueMember)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    comboBox.DataSource = table;
                    comboBox.DisplayMember = displayMember;
                    comboBox.ValueMember = valueMember;
                    comboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitaplariDataGridViewGoster()
        {
            try
            {
                var kitaplar = kitapBL.TumKitaplariGetir();

                if (kitaplar == null || kitaplar.Count == 0)
                {
                    MessageBox.Show("Hiç kitap bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgv_KitapListesi.DataSource = kitaplar;

                dgv_KitapListesi.Columns["ID"].HeaderText = "Kitap ID";
                dgv_KitapListesi.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                dgv_KitapListesi.Columns["YazarID"].HeaderText = "Yazar Adı";
                // dgv_KitapListesi.Columns["YayineviID"].HeaderText = "Yayınevi";
                dgv_KitapListesi.Columns["KitapTuruID"].HeaderText = "ISBN";
                dgv_KitapListesi.Columns["TurAdi"].HeaderText = "Kitap Türü";
                dgv_KitapListesi.Columns["KitapRafNumarasi"].HeaderText = "Raf Kodu";
                dgv_KitapListesi.Columns["SayfaSayisi"].HeaderText = "Sayfa Sayısı";
                dgv_KitapListesi.Columns["KategoriID "].HeaderText = "Kategori";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kitaplar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormTemizle()
        {
            txt_KitapAdi.Clear();
            txt_SayfaSayisi.Clear();
            txt_ISBN.Clear();
            txt_RafNumarasi.Clear();
            cb_Yayinevi.SelectedIndex = -1;
            cb_KitapTuru.SelectedIndex = -1;
            cb_Kategori.SelectedIndex = -1;
            txt_KitapAdi.Focus();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap yeniKitap = new Kitap
                {
                    KitapAdi = txt_KitapAdi.Text.Trim(),
                    SayfaSayisi = int.TryParse(txt_SayfaSayisi.Text.Trim(), out int sayfaSayisi) ? sayfaSayisi : 0,
                    ISBN = txt_ISBN.Text.Trim(),
                    RafNumarasi = Convert.ToInt32(txt_RafNumarasi.Text.Trim()),
                    YayinEvi = Convert.ToInt32(cb_Yayinevi.SelectedValue),
                    KitapTuru = Convert.ToInt32(cb_KitapTuru.SelectedValue),
                    Kategori = Convert.ToInt32(cb_Kategori.SelectedValue)
                };

                string sonuc = kitapBL.KitapEkle(yeniKitap);

                if (sonuc == "Kitap başarıyla eklendi.")
                {
                    MessageBox.Show(sonuc, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormTemizle();
                    KitaplariDataGridViewGoster();
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
    }
}