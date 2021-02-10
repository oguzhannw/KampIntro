using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gercek = Indıvidual
    //GercekMusteri:Musteri
    class GercekMusteri:Musteri
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }   ** Bunlar Musteri sınıfında zaten var o yüzden burada gerek yok.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; } //Sayısal verilerde 4 işlem yapılmayacaksa double,int,long yerine string yazılır.
    }
}
