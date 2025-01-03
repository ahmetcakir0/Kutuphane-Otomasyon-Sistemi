using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class SorumluKayitForm : Form
    {
        public SorumluKayitForm()
        {
            InitializeComponent();
        }
        public class Sorumlular
        {
            public string TCKimlikNo { get; set; }
            public string SorumluAdi { get; set; }
            public string SorumluSoyadi { get; set; }
            public string TelNo { get; set; }
            public string EPosta { get; set; }
            public string Adres { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }

            public Sorumlular(string tcKimlikNo, string sorumluAdi, string sorumluSoyadi, string telNo, string ePosta, string adres, DateTime dogumTarihi, string kullaniciAdi, string sifre)
            {
                TCKimlikNo = tcKimlikNo;
                SorumluAdi = sorumluAdi;
                SorumluSoyadi = sorumluSoyadi;
                TelNo = telNo;
                EPosta = ePosta;
                Adres = adres;
                DogumTarihi = dogumTarihi;
                KullaniciAdi = kullaniciAdi;
                Sifre = sifre;
            }
        }
    }
}
