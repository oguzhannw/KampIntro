using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            // BUNLAR YERİNE BU DA YAZILABİLİR ÇÜNKÜ Interface onu referans alan classı tutabilir.
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            Console.WriteLine("**************************************");
            //***esnaf ve sms sonradan eklendi.*** YENİ TALEP GELDİĞİNDE YENİ SINIFLAR OLUŞTURMAK ÇOK KOLAY.
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }); //Ekrandaki hangi kredi türünü seçerse o yazılır.
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
