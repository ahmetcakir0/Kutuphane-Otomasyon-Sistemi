
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kitaplar
    {
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }
        public string ISBN { get; set; }
        public string RafNumarasi { get; set; }
        public string KitapTuru { get; set; }
        public string Kategori { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitaplar(int id, string kitapAdi, string yazarAdi, string yayinEvi, string isbn, string rafNumarasi, string kitapTuru, string kategori, int sayfaSayisi)
        {
            ID = id;
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            YayinEvi = yayinEvi;
            ISBN = isbn;
            RafNumarasi = rafNumarasi;
            KitapTuru = kitapTuru;
            Kategori = kategori;
            SayfaSayisi = sayfaSayisi;
        }
        public Kitaplar()
        {

        }
    }
}
