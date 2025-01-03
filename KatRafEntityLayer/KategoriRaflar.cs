using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatRafEntityLayer
{
    public class KategoriRaflar
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriRafKodu { get; set; }

        public KategoriRaflar(int id, string kategoriAdi, int kategoriRafKodu)
        {
            ID = id;
            KategoriAdi = kategoriAdi;
            KategoriRafKodu = kategoriRafKodu;
        }
        public KategoriRaflar() { }
    }
}
