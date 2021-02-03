using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediMaganer ihtiyacKrediMaganer = new IhtiyacKrediMaganer();
            
            IKrediMaganer tasitKrediMaganer = new TasitKrediMaganer();
     
            IKrediMaganer konutKrediManager = new KonutKrediMaganer();
            ILoggerService datebaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruMaganer basvuruMaganer = new BasvuruMaganer();
            basvuruMaganer.BasvuruYap(ihtiyacKrediMaganer, new DatebaseLoggerService);

            List<IKrediMaganer> krediler = new List<IKrediMaganer>(){ ihtiyacKrediMaganer, tasitKrediMaganer
            };

            //basvuruMaganer.KrediOnBilgilendirmesiYap(krediler); 




        }

        private static List<T> List<T>()
        {
            throw new NotImplementedException();
        }
    }
}
