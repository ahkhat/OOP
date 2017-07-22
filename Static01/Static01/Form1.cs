using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = "erdi";
            o.Soyad = "yalçın";
            o.Alan = EnumAlan.EsitAgirlik ;
            
            Ogrenci o2 = new Ogrenci();
            o2.Ad = "erkan";
            o2.Soyad = "yalçın";
            o2.Alan = EnumAlan.EsitAgirlik;
            MessageBox.Show(Ogrenci.ToplamSayisi.ToString());//2 from arasında veri alırken mesela static kullanılmalı

            cmbAlan.DataSource = Enum.GetValues(typeof(EnumAlan));//cobobox'ın içi enumdaki listeyle dolu artık.

        }

        private void cmbAlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Ad = TxtAd.Text;
            o.Soyad = TxtSoyad.Text;
            o.Alan = (EnumAlan)cmbAlan.SelectedItem;//enum iiçindekiler comboxta emin olabilrisin diyor
            listBox1.Items.Add(o);

            ListViewItem li = new ListViewItem();//listview a veri aktaramak
            li.Text = o.Ad;
            li.SubItems.Add(o.Soyad);
            li.SubItems.Add(o.Alan.ToString());
            listviewogrenci.Items.Add(li);


            TxtAd.Text = "";
            TxtSoyad.Text = "";
            switch (o.Alan)//enumun özelliklerinden biri
            {
                case EnumAlan.Sayisal:
                    MessageBox.Show("sayisal Öğrencisi");
                    break;
                case EnumAlan.Sözel:
                    break;
                case EnumAlan.EsitAgirlik:
                    break;
                case EnumAlan.Dil:
                    break;
                default:
                    break;
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (listviewogrenci.SelectedItems.Count == 0)
           { List<Ogrenci> silinecekOgrenciler = new List<Ogrenci>();
                return;
                foreach(var ogr in listviewogrenci.SelectedItems)
                {
                    silinecekOgrenciler.Add((Ogrenci)ogr);
                }
                foreach (var ogr in silinecekOgrenciler)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = ogr.Ad;
                    li.SubItems.Add(ogr.Soyad);
                    li.SubItems.Add(ogr.Alan.ToString());
                    listviewogrenci.Items.Remove(li);
                }
            }*/
        }
    }
}
