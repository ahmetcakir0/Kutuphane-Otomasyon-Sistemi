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
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void btn_KitapKayit_Click(object sender, EventArgs e)
        {
            YeniKitapKayitForm kitapKayitForm = new YeniKitapKayitForm();
            kitapKayitForm.Show();
        }

        private void btn_KisiKayit_Click(object sender, EventArgs e)
        {
            YeniUyeKayitForm uyeKayitForm = new YeniUyeKayitForm();
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

        private void btn_OduncIade_Click(object sender, EventArgs e)
        {
            OduncIadeForm oduncIadeForm = new OduncIadeForm();
            oduncIadeForm.Show();
        }

        private void btn_KategoriRaflar_Click(object sender, EventArgs e)
        {
            Kategori_Raflar_Form kategori_Raflar_Form = new Kategori_Raflar_Form();
            kategori_Raflar_Form.Show();
        }

        private void btn_Raporlar_Click(object sender, EventArgs e)
        {
            RaporlarForm raporlarForm = new RaporlarForm();
            raporlarForm.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
