using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayineviEntityLayer
{
    public class Yayinevi
    {
        public int id {  get; set; }
        public string YayineviAdi { get; set; }
        public string TelNo  { get; set; }  
        public string Eposta { get; set; }
        public string Adres { get; set; }

        public Yayinevi(int id, string yayineviAdi, string telNo, string eposta, string adres)
        {
            this.id = id;
            YayineviAdi = yayineviAdi;
            TelNo = telNo;
            Eposta = eposta;
            Adres = adres;
        }
    }
}
