using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDP_Giris
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //string ad = txtAd.Text;
            //string soyad = txtSoyad.Text;
            //decimal numara = numNumara.Value;
            //MessageBox.Show(ad + " " + soyad);
            //txtAd.Text = "";
            //txtSoyad.Text = "";
            //txtAd.Focus();

            Ogrenci ogr = new Ogrenci();
            ogr.ad = txtAd.Text;
            ogr.soyad = txtSoyad.Text;
            ogr.numara = numNumara.Value;


            Ogrenci ogr2 = new Ogrenci(10);
            ogr2.ad = txtAd.Text;
            ogr2.soyad = txtSoyad.Text;
            
            Ogrenci ogr3 = 
                new Ogrenci(txtAd.Text,txtSoyad.Text,numNumara.Value);

            MessageBox.Show(ogr.ad + " " + ogr.soyad);

            txtAd.Text = "";
            txtSoyad.Text = "";
            numNumara.Value = 0;
            txtAd.Focus();

        }


    }
}
