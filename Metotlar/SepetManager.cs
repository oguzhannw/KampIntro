using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax -yazım şekli
        public void Ekle(Urun urun) //Program.cs'de Ekle çağırınca bu satırlar işler
        {
            Console.WriteLine("Tebrikler! Ürün sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler! Ürün sepete eklendi : " + urunAdi);
        }

    }
}
