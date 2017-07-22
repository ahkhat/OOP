using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inherit02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseClass ts = new BaseClass();
            türetilmisSinif tus = new türetilmisSinif();//türetilmiş sınıfın cont. olsa dahi türeilmiş sınıfın nesnesi önce temel sınıfındaki kurucu fonsiyon çalıştırır sonra gider türetilmiş sınıftaki fonksiyonu çalıştırır.
            lstSonuclar.Items.Add(ts.CalistirTemelSinif());
            lstSonuclar.Items.Add(tus.CalistirTemelSinif());//turetilmiş bir su-ınıftan üretilen nesne ile base calsstaki bir fonksiytonu çalıştırailiyosun.
            lstSonuclar.Items.Add(tus.CalistirTUS());

            türetilmisSinif tus2 = new türetilmisSinif("Erdi", "yalçın");
        }
    }
}
