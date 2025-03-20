using Kütuphane_Otomasyon_Sistemi;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class OduncForm : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";
        private int SecilenKitapID;
        private int SecilenUyeID;
        private int oduncSuresi;
        private decimal cezaTutari;

        public OduncForm()
        {
            InitializeComponent();
            try
            {
                AyarlariYukle();
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AyarlariYukle()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT OduncSuresi, CezaUcreti FROM Ayarlar";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oduncSuresi = reader.IsDBNull(0) ? 15 : reader.GetInt32(0);
                            cezaTutari = reader.IsDBNull(1) ? 5 : reader.GetDecimal(1);
                        }
                        else
                        {
                            oduncSuresi = 15;
                            cezaTutari = 5;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oduncSuresi = 15;
                cezaTutari = 5;
                MessageBox.Show("Ayarlar okunurken hata oluştu: " + ex.Message);
            }
        }

        private void btn_UyeAra_Click(object sender, EventArgs e)
        {
            using (UyeAraPopupForm uyeAraPopupForm = new UyeAraPopupForm(connectionString))
            {
                if (uyeAraPopupForm.ShowDialog() == DialogResult.OK)
                {
                    SecilenUyeID = uyeAraPopupForm.SecilenUyeID;
                    txt_AlacakKisi.Text = uyeAraPopupForm.SecilenUyeAdiSoyadi;
                }
            }
        }

        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            using (KitapAraPopupForm kitapAraPopupForm = new KitapAraPopupForm(connectionString))
            {
                if (kitapAraPopupForm.ShowDialog() == DialogResult.OK)
                {
                    SecilenKitapID = kitapAraPopupForm.SecilenKitapID;
                    txt_AlınacakKitap.Text = kitapAraPopupForm.SecilenKitapAdi;

                    // Kitap daha önce ödünç alındı mı ve iade edilmedi mi kontrolü
                    if (IsKitapOduncAlinmis(SecilenKitapID))
                    {
                        MessageBox.Show("Bu kitap daha önce ödünç alınmış ve iade edilmemiş. Lütfen iade edilmesini bekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_AlınacakKitap.Clear(); // Kitap adı temizlenebilir
                        SecilenKitapID = 0; // SecilenKitapID sıfırlanır
                    }
                }
            }
        }
        private bool IsKitapOduncAlinmis(int kitapID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT COUNT(*) 
                FROM Odunc 
                WHERE KitapID = @KitapID AND IadeEdilenTarih IS NULL"; // Kitap iade edilmemişse

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@KitapID", kitapID);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0; // Eğer 1 veya daha fazla ödünç alınmış kitap varsa, true döner
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap ödünç durumu kontrol edilirken hata oluştu: " + ex.Message);
                return false;
            }
        }
        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_AlacakKisi.Text) || string.IsNullOrEmpty(txt_AlınacakKitap.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DateTime verilenTarih = dt_VerilenTarih.Value;
                DateTime geriVerilmesiGerekenTarih = verilenTarih.AddDays(oduncSuresi);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Odunc (KitapID, UyeID, OduncVerilenTarih, GeriVerilmesiGerekenTarih, CezaTutari)
                               VALUES (@KitapID, @UyeID, @OduncVerilenTarih, @GeriVerilmesiGerekenTarih, @CezaTutari)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@KitapID", SecilenKitapID);
                        cmd.Parameters.AddWithValue("@UyeID", SecilenUyeID);
                        cmd.Parameters.AddWithValue("@OduncVerilenTarih", verilenTarih);
                        cmd.Parameters.AddWithValue("@GeriVerilmesiGerekenTarih", geriVerilmesiGerekenTarih);
                        cmd.Parameters.AddWithValue("@CezaTutari", 0); // Başlangıçta ceza 0
                        cmd.ExecuteNonQuery();
                    }
                }

                ListeyiYenile();
                MessageBox.Show($"Ödünç işlemi başarılı! Ödünç süresi: {oduncSuresi} gün", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Temizle_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListeyiYenile()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT o.ID, o.UyeID, u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, 
                       o.KitapID, k.KitapAdi, o.OduncVerilenTarih, 
                       o.GeriVerilmesiGerekenTarih,o.IadeEdilenTarih, o.CezaTutari
                FROM Odunc o
                INNER JOIN Uyeler u ON o.UyeID = u.ID
                INNER JOIN Kitaplar k ON o.KitapID = k.ID";

                    DataTable dt = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        dgv_OduncListesi.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Liste boş. Veritabanında ödünç kitap yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yenilenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            txt_AlacakKisi.Clear();
            txt_AlınacakKitap.Clear();
            dt_VerilenTarih.Value = DateTime.Now;
            dgv_OduncListesi.ClearSelection();
        }

        private void ListeyiYenileOdunc()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
            SELECT o.ID, o.UyeID, u.Ad + ' ' + u.Soyad AS UyeAdiSoyadi, 
                   o.KitapID, k.KitapAdi, o.OduncVerilenTarih, 
                   o.GeriVerilmesiGerekenTarih,o.IadeEdilenTarih, o.CezaTutari, o.IadeNotu
            FROM Odunc o
            INNER JOIN Uyeler u ON o.UyeID = u.ID
            INNER JOIN Kitaplar k ON o.KitapID = k.ID"; // WHERE şartı kaldırıldı

                    DataTable dtOdunc = new DataTable();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtOdunc);
                    }

                    dgv_OduncIade.DataSource = dtOdunc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yenilenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)  // TabPage 1 (Ödünç Verme)
            {
                ListeyiYenile(); // Ödünç verilen kitapları listele
            }
            else if (tabControl1.SelectedIndex == 1)  // TabPage 2 (İade Etme)
            {
                ListeyiYenileOdunc(); // İade edilmemiş kitapları listele
            }
        }

        private void btn_IadeKaydet_Click(object sender, EventArgs e)
        {
            if (dgv_OduncIade.SelectedRows.Count > 0)
            {
                int oduncID = Convert.ToInt32(dgv_OduncIade.SelectedRows[0].Cells["ID"].Value);
                DateTime geriVerilmesiGerekenTarih = Convert.ToDateTime(dgv_OduncIade.SelectedRows[0].Cells["GeriVerilmesiGerekenTarih"].Value);
                DateTime iadeEdilenTarih = dt_GeriVerilenTarih.Value;
                string iadeNotu = txt_IadeNotu.Text.Trim();
                decimal cezaTutari = GetCezaTutari(); // Günlük ceza tutarını al
                decimal toplamCeza = 0;

                // Ceza Hesaplama (Gecikme varsa ceza eklenir)
                if (iadeEdilenTarih > geriVerilmesiGerekenTarih)
                {
                    TimeSpan gecikme = iadeEdilenTarih - geriVerilmesiGerekenTarih;
                    toplamCeza = gecikme.Days * cezaTutari; // Gün başına ceza hesapla
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Güncelleme işlemi: Kaydı silmeden bilgileri güncelle
                        string query = @"
                UPDATE Odunc 
                SET IadeEdilenTarih = @IadeEdilenTarih, 
                    IadeNotu = @IadeNotu, 
                    CezaTutari = @CezaTutari 
                WHERE ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@IadeEdilenTarih", iadeEdilenTarih);
                            cmd.Parameters.AddWithValue("@IadeNotu", iadeNotu);
                            cmd.Parameters.AddWithValue("@CezaTutari", toplamCeza);
                            cmd.Parameters.AddWithValue("@ID", oduncID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    ListeyiYenileOdunc(); // Listeyi yenile
                    MessageBox.Show($"Kitap iade edildi. Ceza tutarı: {toplamCeza} TL", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen iade edilecek bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private decimal GetCezaTutari()
        {
            decimal cezaTutari = 5; // Varsayılan ceza tutarı
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT CezaUcreti FROM Ayarlar";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            cezaTutari = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("Ayarlar tablosunda ceza ücreti bulunamadı. Varsayılan ceza ücreti kullanılacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar tablosundan ceza ücreti alınırken hata oluştu: " + ex.Message);
            }
            return cezaTutari;
        }
    }
}