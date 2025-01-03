using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon_Sistemi
{
    public partial class Kategori_Raflar_Form : Form
    {
        public Kategori_Raflar_Form()
        {
            InitializeComponent();
        }
    }
    public class KategoriRaflar
    {
        public string KategoriAdi;
        public string DolapNumarasi;

        public KategoriRaflar(string kategoriAdi, string dolapNumarasi)
        {
            KategoriAdi = kategoriAdi;
            DolapNumarasi = dolapNumarasi;
        }
    }
}
