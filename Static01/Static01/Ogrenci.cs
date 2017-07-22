
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Static01
{
    class Ogrenci
    {
        public string Ad;
        public string Soyad { get; set; }
        public static int ToplamSayisi { get; set; }//static yaparak dışarı aldık global oldu,nesne tanımlamadan çağrılabilir static değişkenler
                                                    //class ismi ile doğrudan ulaşabilrisin artıl ogrenci.vs diyerek
     /*  public static string YoklamaAl()
        {
         
             //ad gelemez: static fonksiyonlar static değişkenlerle işlem yapabilir .
        }*/
        public Ogrenci()
        {
            ToplamSayisi++;
        }
        public EnumAlan Alan { get; set; }
        public override string ToString() { return Ad + " " + Soyad + "(" + Alan + ")"; }//polimorfizm virtual tanımlanmış bir fonksiyon override ile ezilerek kullanılıyorsa bunun adı polimorizm.

    }
    enum EnumAlan
    {
        Sayisal,
        Sözel, EsitAgirlik, Dil//sırayla 0,1,2,3 şeklinde tutuyor dizi gibi. istersen değer verebilirsin
    }//enumlar saddece bunlar giricek şeklinde kısıtlamalar verir.
}