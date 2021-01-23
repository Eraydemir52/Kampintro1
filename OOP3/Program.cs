using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //NOT!!!!!!!!!===========interface leri birbirinin alternetifiolan ama kod içerikleri farklı olan kodlar için kullanılır.
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuruyap(tasıtKrediManager,dataloggerService);
            basvuruManager.Basvuruyap(konutKrediManager, fileloggerService);
            basvuruManager.Basvuruyap(new EsnafKrediManager(), new SmsLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };

          //  basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
