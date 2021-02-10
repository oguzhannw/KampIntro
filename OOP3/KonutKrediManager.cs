using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager //:KrediManager unutma.
    {
        public void BiSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
