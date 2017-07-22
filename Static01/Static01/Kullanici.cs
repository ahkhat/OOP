
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Static01
{
  abstract class Kullanici//abstractlar her sınıfta illa olmsı gerekn değişj-knleri doğrulamak amacıyla kullanılabilir.
    {//ABSTRACT nesne oluşturmasını engeller fakar kalıtıma izin verir.
        public abstract int maas { get; set; }//kesinlikle içindekileri ezer. yani bu sınıftan kalıtım alan herkes bunun içşndeki değişkenleri override ederek 
        //kullanmak zırtundadır. maas gibi bşr değişkenim olursa kalıtım versiğim bütün sınıflar bu maas değişkenini zorunlu olarak override ederek kullanmak zorundaır.

       // kullanıcı sınıfında içi noş bile bırakılsa kalıtım alan sınıf onun içini doldurur.
    }
}