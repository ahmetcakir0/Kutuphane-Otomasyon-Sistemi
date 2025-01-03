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
    public partial class YeniUyeKayitForm : Form
    {
        public YeniUyeKayitForm()
        {
            InitializeComponent();
        }
        public class Uye
        {
            public string TCKimlikNo { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string TelNo { get; set; }
            public string EPosta { get; set; }
            public string Adres { get; set; }
            public DateTime DogumTarihi { get; set; }

            public Uye(string tcKimlikNo, string ad, string soyad, string telNo, string ePosta, string adres, DateTime dogumTarihi)
            {
                TCKimlikNo = tcKimlikNo;
                Ad = ad;
                Soyad = soyad;
                TelNo = telNo;
                EPosta = ePosta;
                Adres = adres;
                DogumTarihi = dogumTarihi;
            }
        }
    }
}
