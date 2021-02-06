using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + " " + musteri.MusteriAdi);
            Console.WriteLine("Müşteri silindi.");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var Musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id:" + Musteri.MusteriId + "  Müşteri Adı:" + Musteri.MusteriAdi);
            }
        }
    }
}
