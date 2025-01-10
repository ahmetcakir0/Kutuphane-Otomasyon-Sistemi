using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Yazarlar
    {
        public int ID { get; set; }
        public string AdiSoyadi { get; set; }
        public string Iletisim { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Biyografi { get; set; }

        public Yazarlar(int id, string adiSoyadi, string ıletisim, string biyografi)
        {
            ID = id;
            AdiSoyadi = adiSoyadi;
            Iletisim = ıletisim;
            Biyografi = biyografi;
        }
        public Yazarlar() { }
    }
}
