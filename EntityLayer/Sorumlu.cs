using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Sorumlu
    {
        public int ID { get; set; }
        public string SorumluAdi { get; set; }
        public string SorumluSoyadi { get; set; }
        public string TCKimlik { get; set; }
        public string Rol { get; set; }
        public string TelNo { get; set; }
        public string Eposta { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Sorumlu(int id, string sorumluAdi, string sorumluSoyadi, string tCKimlik, string rol, string telNo, string eposta, DateTime dogumTarihi, string adres, string kullaniciAdi, string sifre)
        {
            ID = id;
            SorumluAdi = sorumluAdi;
            SorumluSoyadi = sorumluSoyadi;
            TCKimlik = tCKimlik;
            Rol = rol;
            TelNo = telNo;
            Eposta = eposta;
            DogumTarihi = dogumTarihi;
            Adres = adres;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }
    }
}
