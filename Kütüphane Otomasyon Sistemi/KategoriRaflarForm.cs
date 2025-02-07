using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;

namespace Kütüphane_Otomasyon_Sistemi
{
    public partial class KategoriRaflarForm : Form
    {
        KatRafDAL katRafDAL = new KatRafDAL();
        public KategoriRaflarForm()
        {
            InitializeComponent();
        }
    }
    
}
