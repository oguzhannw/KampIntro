using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // Do not repeat yourself = kendini tekrar etme.  
            //Alias = değer tutucu -kategoriEtiketi-.

            string kategoriEtiketi = "Kategori-ler";
            int ogrenciSayisi = 32000;
            double faizeOrani = 1.45;
            bool sistemeGirisYapmisMi = true;  // ya 1'dir ya 2. **Kayıt ol veya Üye ol**
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            //** İF DÖNGÜSÜNÜ TEK SATIRDA YAZMAK İÇİN **
            string sonuc = dolarDun>dolarBugun ? "Azalış" : dolarBugun>dolarDun ? "Artış":"Değişmedi";
            Console.WriteLine(sonuc);

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
