
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kalitim
{
    class Ogrenci:Kullanici
    {
       
    
        public int Numara;

        //buraya öğrencinin notunu koaymıyoruz çünkü not değişken birşeydir . Vize mi finalmi harf notumu bunları bilemiyoruz.

        public string Bolum;
        string Ad;//kalıtım aldığım yerdede aynı değişken var. 
        public string AdSoyad()
        {
           // return Ad + " " + Soyad;//buradaki ad hangi ad bu classtaki ad mı kalıtım aldığımız classtakimi? Buradaki ad kalıtımdaki ad'ı eziyor.Türetilmiş sınıftaki değişken kalıtım alınan ile aynı ise kalıtım alınan değişkeni ezer.
                                    //buradaki ad benim yukarıda tanımladığım ad.
                                    //temel sınıftaki ad'a ulaşabilmek için base.Ad demelisin.
                                     return base.Ad + " " + Soyad;

        }
       /* public string AdSoyad(string Soyad)-->dışarıdan alıyorsun soyadı
        {
           
            return base.Ad + " " + this.Soyad; -->buradaki soyadımı alayım dışarıdan gelenimi this diyorsa buradaki soyad ı alacak.

        }*/

    }
}