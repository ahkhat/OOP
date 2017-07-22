using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDP_Giris
{
    class Ogrenci
    {
        public Ogrenci()//constractor fonksiyonları class ta nesne oluştuğu anda ilk çalışacak fonsiyondur.Geri dönüş tipi yok.
        {
            OlusturulmaTarihi = DateTime.Now;
            ad = "Tanımsız";
            soyad = "Tanımsız";
        }

        public Ogrenci(decimal numara)//bu şekilde birden fazla aynı isimde farklı parametreler içeren fonksitonlar olunca buna overloading denir.
        {
            OlusturulmaTarihi = DateTime.Now;
            ad = "Tanımsız";
            soyad = "Tanımsız";
            this.numara = numara;
        }

        public Ogrenci(string ad, string soyad, decimal numara)//aynı isimde farklı parametrelerle fonksiyon oluşturmak-->overload
        {
            OlusturulmaTarihi = DateTime.Now;
            ad = ad;
            soyad = soyad;
            this.numara = numara; 
            //this.numara Classtaki numara diğer numara ise dışarıdan gelecek numara demek.
        }

        ~Ogrenci()
        { 
            //Yıkıcı Fonksiyon
        }

        public string ad;
        public string soyad;
        internal decimal numara;
        public DateTime OlusturulmaTarihi;
    }
}


/* Access Modifiers - Erişim Denetleyiciler
 * 
 * Private : özelliği sadece tanımlandığı sınıf 
 * içinden erişilebilir yapar.
 * C# da sınıf içinde Access Modifier yazılmadıysa 
 * Private kabul edilir.
 * 
 * Protected : Miras alınan sınıflardan erişilebilir.
 * 
 * Internal  : Bulunduğu proje içindeki heryerden erişilir.
 * 
 * Protected Internal : Hem miras alanlar hemde proje içinden 
 * erişilebilir.
 * 
 * Public   : Her yerden erişilebilmeyi sağlar.
 * Hiçbir kısıtlama yoktur.
 * 
 * 
 * 
 */

/*Constructor - Kurucu Fonksiyon
 * 
 * Kurucu metottur. RAM'de nesneyi üreten metottur.
 * Geriye dönüş tipi olmayan tek metottur.
 * Tanımlanmazsa varsayılan olarak 
 * Default Constructor geçerlidir.
 * (Parametre almayan new Ogrenci() metodu)
 * 
 * Tanımlanırsa Default iptal olur.
 * Tanımlı olan geçerli olur.
 * 
 * Overload yapılabilir.
 */
