using System;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = Menu();
            }
        }
        public static bool Menu()
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 11111;
            musteri1.MusteriAdi = "Engin";
            musteri1.MusteriKrediOrani = 11;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 22222;
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriKrediOrani = 11.75;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("////////Bir seçenek seçiniz///////");
            Console.WriteLine("1-Müşteri Ekle");
            Console.WriteLine("2-Müşteri Silindi");
            Console.WriteLine("3-Müşteriler Listelendi");

            var sonuc = Console.ReadLine();

            MusteriManager musteriManager = new MusteriManager();
            if (sonuc == "1")
            {
                musteriManager.Ekle(musteri1);
                return true;
            }
            else if (sonuc == "2")
            {
                musteriManager.Sil(musteri2);
                return true;
            }
            else if (sonuc == "3") 
            {
                musteriManager.Listele(musteriler);
                return true;
            }
            else
            {
                Console.WriteLine("Bu hizmet kullanılmamaktadır.");
                return true;
            }

        }
    }
}
