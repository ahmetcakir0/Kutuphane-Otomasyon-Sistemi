using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class KategoriRaf
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriRafKodu { get; set; }

        public KategoriRaf(int id, string kategoriAdi, int kategoriRafKodu)
        {
            ID = id;
            KategoriAdi = kategoriAdi;
            KategoriRafKodu = kategoriRafKodu;
        }
        public KategoriRaf() { }
    }
}
