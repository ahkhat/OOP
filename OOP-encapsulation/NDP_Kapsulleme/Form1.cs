using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDP_Kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kullanici> kullanicilar = new List<Kullanici>();//veritabanı olmadan listeleme için Kullanici sınıfının nesnesini oluştur

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Kullanici k = new Kullanici();
            //k.Ad = txtAd.Text;
            //k.Soyad = txtSoyad.Text;
            //k.TCKN = txtTCKN.Text;

            try
            {
                // TCKN kontrolü

                foreach (var kul in kullanicilar)
                {
                    if (kul.TCKN == txtTCKN.Text)
                    {
                        throw new Exception("Farklı TCKN  giriniz...");
                    }
                }

                Kullanici k = new Kullanici();
                k.Ad = txtAd.Text;
                k.Soyad = txtSoyad.Text;
                // TCKN nin set i çalışacak
                k.TCKN=txtTCKN.Text;
                k.DOGUMTarihi = dtpDogum.Value;

                MessageBox.Show(k.Ad + " " + k.Soyad + " : " + k.TCKN + "  -  Yas : " + k.Yas);
                // TCKN nin get i çalışacak
                kullanicilar.Add(k);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnListele_Click(object sender, EventArgs e)//veritabanı olmadan görüntüleme için list kullanıdık
        {
            foreach (var k in kullanicilar)
            {
                lstKullanicilar.Items.Add(k.Ad +" "+k.Soyad + " : " + k.Yas);
            }
        }

        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
