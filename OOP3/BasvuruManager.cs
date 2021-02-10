using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //ınterfaceden referans aldık.
        {
            //Başvuran bilgilerini değerlendirme.
            //
            krediManager.Hesapla(); //Buraya hangi kredi gönderilirse onun hesaplası çalışır.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
