using Kütuphane_Otomasyon_Sistemi;
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
    public partial class OduncForm : Form
    {
        private string connectionString = "server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI";

        // Seçilen Kitap ve Üye ID'lerini saklayacak değişkenler
        private int SecilenKitapID;
        private int SecilenUyeID;

        public OduncForm()
        {
            InitializeComponent();
        }

        private void btn_UyeAra_Click(object sender, EventArgs e)
        {
            UyeAraPopupForm uyeAraPopupForm = new UyeAraPopupForm(connectionString);

            // Kullanıcı bir üye seçerse (DialogResult.OK)
            if (uyeAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                // Seçilen üye bilgilerini alıyoruz
                SecilenUyeID = uyeAraPopupForm.SecilenUyeID;
                txt_AlacakKisi.Text = uyeAraPopupForm.SecilenUyeAdiSoyadi; // Üye adı soyadını gösteriyoruz
            }
        }
        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            KitapAraPopupForm kitapAraPopupForm = new KitapAraPopupForm(connectionString);

            // Kullanıcı bir kitap seçerse (DialogResult.OK)
            if (kitapAraPopupForm.ShowDialog() == DialogResult.OK)
            {
                // Seçilen kitap bilgilerini alıyoruz
                SecilenKitapID = kitapAraPopupForm.SecilenKitapID;
                txt_AlınacakKitap.Text = kitapAraPopupForm.SecilenKitapAdi; // Kitap adını gösteriyoruz
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Kitap ID'sini ve Üye ID'sini aldık, diğer parametreler ile ödünç verme işlemi yapılacak
                int kitapID = SecilenKitapID;
                int uyeID = SecilenUyeID;

                // Diğer veriler (tarihler vb.) alınacak
                DateTime verilenTarih = dt_VerilenTarih.Value;
                DateTime verilmesiGerekenTarih = dt_VerilmesiGerekenTarih.Value;

                // Ödünç verme işlemi
                string query = @"INSERT INTO Odunc (KitapID, UyeID, OduncVerilenTarih, GeriVerilmesiGerekenTarih)
                                 VALUES (@KitapID, @UyeID, @OduncVerilenTarih, @GeriVerilmesiGerekenTarih)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@KitapID", kitapID);
                    cmd.Parameters.AddWithValue("@UyeID", uyeID);
                    cmd.Parameters.AddWithValue("@OduncVerilenTarih", verilenTarih);
                    cmd.Parameters.AddWithValue("@GeriVerilmesiGerekenTarih", verilmesiGerekenTarih);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Ödünç işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
