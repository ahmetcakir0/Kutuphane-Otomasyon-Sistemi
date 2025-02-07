
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Kitap
    {
        public int ID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public int YayinEvi { get; set; }
        public string ISBN { get; set; }
        public int RafNumarasi { get; set; }
        public int KitapTuru { get; set; }
        public int Kategori { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap(int id, string kitapAdi, string yazarAdi, int yayinEvi, string isbn, int
            rafNumarasi, int kitapTuru, int kategori, int sayfaSayisi)
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
        public Kitap()
        {

        }
    }
}
