
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Inherit02
{
    class BaseClass//-----sealed ----yazılırsa başına bundan kalıtım alınması engellenir.
    {
        public string Ad;
        public string Soyad;

        public BaseClass()//constractor-->formda ilk nesne oluşunca direk burası çalışacak. Türemiş sınıf nesnesi oluşunca kendisinin const. yok oyüzden a da ilk önce temel sınıfın cont. çalıştırıyor.
            //türetilmiş sınıfın cont. olsa dahi türeilmiş sınıfın nesnesi önce temel sınıfındaki kurucu fonsiyon çalıştırır sonra gider türetilmiş sınıftaki fonksiyonu çalıştırır.
        {
            Ad = "Temel Ad";
        }
        public BaseClass(string ad,string soyad)
        {
            Ad = ad;
           this.Soyad = soyad;
        }
        /*  public string CalistirTemelSinif()
          {
              return "Temel sınıf Çalıştı.";
          }*/
        public virtual string CalistirTemelSinif()//virtual ile tanımlanan fonksiyon override ile ezilebilir.
        {
            return "Temel sınıf Çalıştı.";
        }
    }
}