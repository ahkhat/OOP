using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//kurucu fonksiyonlar nedir ne işe yarar.Constractor  işte.
namespace NDP_Kapsulleme
{//kapsülleme verinin korunmasını sağlar katman katman. Yaş 0 dan küçük girilemez gibi.
    class Kullanici
    {
        public string Ad;
        public string Soyad;
        private string tckn;
        private DateTime dogumTarihi;

        public DateTime DOGUMTarihi
        {
            get { return dogumTarihi; }//get-->çağırırken
            set
            {
                if ((int)((DateTime.Now - value).TotalDays / 365) >= 18)
                {
                    dogumTarihi = value;
                }
                else
                {
                    throw new Exception("18 yaşından küçükler çalıştırılamaz.");
                }
            }
        }


        public int Yas
        {
            get
            {
                return (int)((DateTime.Now - dogumTarihi).TotalDays / 365);//burada dogum tarihi yerine value yazamıyoruz çünkü set etmedik. bu yüzden bu classtaki private değişken olan dogumtarihini kullanabilir.
            }
        }


        public string TCKN//properties {} açınca bu bir property oluyor.
        {
            get
            {
                return tckn;
            }
            set
            {
                if (value.Length == 11)//property'e dışarıdan gönderdiğimiz değer value dir.
                    tckn = value;
                else
                    throw new
                        Exception("TCKN 11 haneli olmalıdır.");//dışarıdan girilen değer 11 haen değilse hata kodu
            }
        }















        //public void setTCKN(string value)
        //{
        //    if (value.Length == 11)
        //        TCKN = value;
        //    else
        //        throw new Exception("TCKN 11 haneli olmalıdır.");
        //}

        //public string getTCKN()
        //{
        //    return TCKN;
        //}

    }
}
