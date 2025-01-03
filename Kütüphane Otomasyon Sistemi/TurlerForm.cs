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
    public partial class TurlerForm : Form
    {
        public TurlerForm()
        {
            InitializeComponent();
        }
    }
    public class Turler
    {
        public string TurAdi;
        public string Aciklama;

        public Turler(string turAdi, string aciklama)
        {
            TurAdi = turAdi;
            Aciklama = aciklama;
        }
    }
}
