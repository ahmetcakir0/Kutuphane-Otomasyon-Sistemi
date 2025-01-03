using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurlerEntityLayer
{
    public class Turler
    {
        public class Tur
        {
            public int ID { get; set; }
            public string TurAdi { get; set; }
            public string Aciklama { get; set; }

            public Tur(int id, string turAdi, string aciklama)
            {
                ID = id;
                TurAdi = turAdi;
                Aciklama = aciklama;
            }

            public Tur()
            {

            }
        }
    }
}
