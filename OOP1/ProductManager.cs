using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //CRUD **eklenen ürünü YENİLEMEK,GELİŞTİRMEK,GÜNCELLEMEK,SİLMEK.
    //BUNLARI BU SINIFA YAZDIK. ProductManager yerine ProductService olabilirdi
    class ProductManager
    {
        public void Add(Product product) //Bana Product(ürünler) sınıfından bir tane product(ürün) ver.
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }







        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2; // ** RETURN önemlidir çünkü bu toplama işleminin sonucunu başka bir yerde kullanmamızı sağlar.
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
