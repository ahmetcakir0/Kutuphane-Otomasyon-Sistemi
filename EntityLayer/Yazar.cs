using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Yazar
    {
        public int ID { get; set; }
        public string AdiSoyadi { get; set; }
        public string Iletisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Biyografi { get; set; }

        public Yazar(int id, string adiSoyadi, string ıletisim, DateTime dogumTarihi, string biyografi)
        {
            ID = id;
            AdiSoyadi = adiSoyadi;
            Iletisim = ıletisim;
            DogumTarihi = dogumTarihi;
            Biyografi = biyografi;
        }
        public Yazar() { }
    }
}
