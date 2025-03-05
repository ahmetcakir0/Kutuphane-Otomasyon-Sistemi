using Kutuphane_Otomasyon_Sistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class AnaMenuForm : Form
    {
        private string kullaniciAdi;
        public AnaMenuForm(string ad, string soyad)
        {
            InitializeComponent();
            kullaniciAdi = $"{ad} {soyad}   ";
        }


        private void btn_KitapKayit_Click(object sender, EventArgs e)
        {
            YeniKitapKayitForm yeniKitapKayitForm = new YeniKitapKayitForm();
            yeniKitapKayitForm.Show();
        }

        private void btn_KisiKayit_Click(object sender, EventArgs e)
        {
            UyeKayitForm uyeKayitForm = new UyeKayitForm();
            uyeKayitForm.Show();
        }

        private void btn_SorumluKayit_Click(object sender, EventArgs e)
        {
            SorumluKayitForm sorumluKayitForm = new SorumluKayitForm();
            sorumluKayitForm.Show();
        }

        private void btn_YazarKayit_Click(object sender, EventArgs e)
        {
            YazarKayitForm yazarKayitForm = new YazarKayitForm();
            yazarKayitForm.Show();
        }

        private void btn_YayineviKayit_Click(object sender, EventArgs e)
        {
            YayineviForm yayineviForm = new YayineviForm();
            yayineviForm.Show();
        }

        private void btn_TurlerKayit_Click(object sender, EventArgs e)
        {
            TurlerForm turlerForm = new TurlerForm();
            turlerForm.Show();
        }

        private void btn_OduncVerme_Click(object sender, EventArgs e)
        {
            OduncForm oduncForm = new OduncForm();
            oduncForm.Show();
        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonForm rezervasyonForm = new RezervasyonForm();
            rezervasyonForm.Show();
        }

        private void btn_KategoriRaflar_Click(object sender, EventArgs e)
        {
            KategoriRaflarForm kategoriRaflarForm = new KategoriRaflarForm();
            kategoriRaflarForm.Show();
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            RaporlarForm raporlarForm = new RaporlarForm();
            raporlarForm.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Ayarlar ayalar = new Ayarlar();
            ayalar.Show();
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            lbl_Hosgeldiniz.Text = $"Hoşgeldiniz {kullaniciAdi}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
