
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Kalitim//base class ortak değişkenler burada
{//bütün classlara ad,soyad gibi aynı şeyleri ekledik. Bunun tekrarlanması hoş değil. Buyüzden bir base oluşturulur mesela ad soyadbase olursa tüm classlar için
    //memur için ısegiristarihi child'ı olur.
    class Kullanici
    {
       public string Ad;
        public string Soyad;
        public string TCno;
        public DateTime DogumTarihi;
        protected internal string Cinsiyet;//aynı sınıf içinden veya bu sınıfı miras alan sınıflar içerisinde erişilebilir demek-->protected
        //protected internal ise nesne ürettiğimiz yerde de erişilir.
      
    }
}