using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Uyeler
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKimlik { get; set; }
        public string TelNo { get; set; }
        public string Eposta { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Adres { get; set; }

        public Uyeler(int id, string ad, string soyad, string tCKimlik, string telNo, string eposta, DateTime dogumTarihi, string adres)
        {
            ID = id;
            Ad = ad;
            Soyad = soyad;
            TCKimlik = tCKimlik;
            TelNo = telNo;
            Eposta = eposta;
            DogumTarihi = dogumTarihi;
            Adres = adres;
        }
        public Uyeler()
        {

        }
    }
}
