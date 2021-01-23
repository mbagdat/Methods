using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //INTERFACELER REFERANS BİLGİSİ TUTARLAR


            IKrediService ihtiyacKrediService = new IhtiyacKrediManager();
            IKrediService tasitKediService = new TasitKediManager();
            IKrediService konutKrediService = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();

            BasvuruManager basvuruService = new BasvuruManager();
            basvuruService.BasvuruYap(ihtiyacKrediService, FileLoggerService);


            List<IKrediService> krediler = new List<IKrediService>() {ihtiyacKrediService ,tasitKediService};

            //basvuruService.KrediOnBilgilendirme(krediler);
        }
    }
}
