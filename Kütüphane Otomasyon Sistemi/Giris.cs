using Kütüphane_Otomasyon_Sistemi;
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
    public partial class Giris : Form
    {
        public static string loggedInUserRole = "";
        public Giris()
        {
            InitializeComponent();
            this.AcceptButton = btn_Giris; // GİRİŞ butonu Enter tuşuyla çalışır

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txt_KullaniciAdi.Text.Trim();
            string Sifre = txt_Sifre.Text.Trim();

            if (string.IsNullOrEmpty(KullaniciAdi) || string.IsNullOrEmpty(Sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection("server=MBB-01-BIL065-N\\SQLEXPRESS; Initial Catalog=KutuphaneDB; Integrated Security=SSPI"))
            {
                conn.Open();
                string query = "SELECT SorumluAdi, SorumluSoyadi, Rol FROM Sorumlular WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", Sifre);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Eğer veri varsa
                {
                    string ad = reader["SorumluAdi"].ToString();
                    string soyad = reader["SorumluSoyadi"].ToString();
                    loggedInUserRole = reader["Rol"].ToString();

                    MessageBox.Show($"Giriş başarılı, Hoşgeldiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    AnaMenuForm anaMenuForm = new AnaMenuForm(ad, soyad); // Ad ve soyadı parametre olarak gönderiyoruz
                    anaMenuForm.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
                    anaMenuForm.WindowState = FormWindowState.Maximized;
                    anaMenuForm.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
