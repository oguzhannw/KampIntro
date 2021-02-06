using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun // **Urunlerin ozellikleri(Property)
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyatı { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
