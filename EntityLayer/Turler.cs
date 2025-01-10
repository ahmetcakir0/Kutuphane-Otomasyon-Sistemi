using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Turler
    {
        public int ID { get; set; }
        public string TurAdi { get; set; }
        public string Aciklama { get; set; }

        public Turler(int id, string turAdi, string aciklama)
        {
            ID = id;
            TurAdi = turAdi;
            Aciklama = aciklama;
        }

        public Turler()
        {

        }
    }
}
