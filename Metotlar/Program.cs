using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyat = 15;
            //string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 40;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 10;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // type-safe == tip güvenliği
            foreach (Urun urun in urunler) // ** Urunlerın içindeki her ürünü tek tek gezer **
            {
                
                Console.WriteLine("Adı : "+ urun.Adi);
                Console.WriteLine("Fiyatı : "+urun.Fiyatı);
                Console.WriteLine("Açıklama : "+urun.Aciklama);
                Console.WriteLine("Stok : "+urun.StokAdedi);
                Console.WriteLine("///////////////");
                //BUNUN YERİNE 
                //Console.WriteLine("Ürün Adı:" + urun.Adi + "  Fiyatı:" + urun.Fiyatı + "  Açıklama:" + urun.Aciklama);
            }

            Console.WriteLine("------------------METOTLAR-------------");

            //instence =örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //**SEPETİN AÇIKLAMASINI DEĞİŞTİRMEK İÇİN TEK TEK DEĞİŞTİRMEK YERİNE SepetManager.cs'den değiştirdik.

            // ** BU YÖNTEM SAĞLIKLI DEĞİLDİR-- BUNUN YERİNE ENCAPSULATİON DAHA YARARLIDIR.
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

        }
    }
}
