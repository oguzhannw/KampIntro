using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet=prop yapınca tab tab yapınca gelen hazır kodlara denir.
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } 
        public string ProductName { get; set; } //Ürün adı
        public double UnitPrice { get; set; } //Br fiyatı
        public int UnitsInStock { get; set; } //Stok adedi

    }
}
