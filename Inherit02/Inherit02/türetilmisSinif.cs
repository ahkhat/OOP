
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Inherit02
{
    class türetilmisSinif:BaseClass
    {
        public türetilmisSinif()
        {
            Ad = "türetilmiş ad";
        }
        public türetilmisSinif(string ad,string soyad):base(ad,soyad)//nesneden sonra kururcu fonksiyon çalıştıktan sonra bu fonksiyon yerine temel sınıftaki fonk. kullanılsın.-->buradan parametre alıp base'e gönderdim.
        {
          //  Ad = ad;
         //   Soyad = soyad;
        }
        public türetilmisSinif(string ad) : base(ad, "belirtilmedi")//dışarıdan alınanları temel class'a bu şekilde gönderebilirdik.-->bunu yapma sebebim mesela öğrenci için yapabilirim memeur için yaopabilirim kullanıcı ortak
        {
        }
        
        public string CalistirTUS()
        {
            return "türetilmiş sınıf çalıştı.";
        }
        //new public string CalistirTemelSinif()//temel sınıftaki aynı isimdeki fonksiyonu kullanmak için new yazarak uyarıyı geçiyoruz.temel sınıftaki fonksiyonu ezer
         public override string CalistirTemelSinif()//virtual ile tanımlanan fonksiyon override ile ezilebilir.
        {
            return"Türetilmiş sınıf çalıştı-2";
        }
    }

}