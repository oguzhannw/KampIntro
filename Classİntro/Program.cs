using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Oğuzhan Karaoğlan";
            kurs2.IzlenmeOranı = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;

            //Console.WriteLine("Program:"+ kurs1.KursAdi + "  Egitmen:" + kurs1.Egitmen + "  Izlenme Oranı:" + kurs1.IzlenmeOranı);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3}; //**DÖNGÜ ARREY OLUŞTURDUK **

            foreach (var kurs in kurslar)  // ** DÖNGÜYÜ FOREACH İLE DÖNDÜK **
            {
                Console.WriteLine("Program:" + kurs.KursAdi + "  Egitmen:" + kurs.Egitmen + "  Izlenme Oranı:" + kurs.IzlenmeOranı);
            }
        }

    }

    class Kurs
    {
        //prop TABTAB
        public string KursAdi { get; set; }
        public  string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }

}
