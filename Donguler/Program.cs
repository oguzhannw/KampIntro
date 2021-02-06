using System;
using System.Globalization;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";
            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            ////////////////////// TEK TEK YAZMAK YERRİNE DİNAMİK KOD İÇİN DÖNGÜ KULLANDIK ///////////////////////////////
            //array = dizi   **string[]**
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı" , 
                "Programlamaya başlangıç için temel kurs" , "Java", "Python" };
            for (int i = 0; i < 4; i++)  
            {
                Console.WriteLine(kurslar[i]);
            }
            ///////////////////// FARKLI BİR YAZIM YÖNTEMİ /////////////////////////////////////
            foreach (string kurs in kurslar)  // ** Dizi temelli kodları tek tek dönmeye yarar. ** // DİZİLERE UYGULANIR.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu (footer)");
        }
    }
}
