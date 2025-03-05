
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
        public int YazarID { get; set; }
        public int YayineviID { get; set; }
        public int KitapTuruID { get; set; }
        public int KategoriID { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string YayineviAdi { get; set; }
        public string KitapTuruAdi { get; set; }
        public string KategoriAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string ISBN { get; set; }

        // Updated constructor without KitapRaf
        public Kitap(int id, string kitapAdi, int yazarID, int yayineviID, int kitapTuruID, int kategoriID,
                     string yazarAdi, string yazarSoyadi, string yayineviAdi, string kitapTuruAdi,
                     string kategoriAdi, int sayfaSayisi, string isbn)
        {
            ID = id;
            KitapAdi = kitapAdi;
            YazarID = yazarID;
            YayineviID = yayineviID;
            KitapTuruID = kitapTuruID;
            KategoriID = kategoriID;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            YayineviAdi = yayineviAdi;
            KitapTuruAdi = kitapTuruAdi;
            KategoriAdi = kategoriAdi;
            SayfaSayisi = sayfaSayisi;
            ISBN = isbn;
        }
    }

}
