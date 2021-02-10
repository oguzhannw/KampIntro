using System;

namespace OOP2
{
    public class Program
    {
        // Gerçek(Bireysel) - Tüzel(Kurumsal)
        public static void Main(string[] args)
        {
            //Engin Demiroğ // GERÇEK MUSTERİ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "222222";
            musteri1.MusteriNo = "12345";

            //Kodlama.io //TUZEL MUSTERİ
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.Id = 2;
            musteri2.MusteriNo = "123456";
            musteri2.VergiNo = "12340000";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            for (int i = 0; i < musteriler.Length; i++)

            {
                Console.WriteLine("Musteri Id = " + musteriler[i].Id + "  *******" + " MusteriNo = " + musteriler[i].MusteriNo);
            }
        }
    }
}
