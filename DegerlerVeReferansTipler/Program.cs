using System;

namespace DegerlerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** int,decimal,float,double,bool = DEĞER TİP 
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;  // SAYI 1 -->> SAYI 2'nin değerini alır sayi1=sayi2=30
            sayi2 = 65;
            Console.WriteLine(sayi1);  //sayi1=30  sayi2=65 olarak kalır.
            Console.WriteLine(sayi2);  //sayi1=30  sayi2=65 olarak kalır.

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // *** array,class,interface = REFERANS TİP
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  // SAYİLAR 1'İN REFERANS NUMARASI SAYİLAR2'YE EŞİT OLUR .sayilar1=sayilar2={100,200,300}
            sayilar2[0] = 999;    //sayilar1=sayilar2={999,200,300} OLDU.
            Console.WriteLine(sayilar2[0]); // ==999
            Console.WriteLine(sayilar1[0]); // ==999
        }
    }
}
