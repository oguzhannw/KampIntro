using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tuzel = Coorporate
    //TuzelMusteri:Musteri (miraz_inheritance)   **MÜŞTERİDE OLAN HER ŞEY TUZELMUSTERİDE DE KABUL EDİLİR.
    class TuzelMusteri:Musteri  //:Musteriyi unutma.
    {
        //public int Id { get; set; }
        //public string MusteriNo { get; set; }    ****** Bunlar Musteri sınıfında zaten var o yüzden burada gerek yok.
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
