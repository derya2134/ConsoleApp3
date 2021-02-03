using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruMaganer
    {
        public void BasvuruYap(IKrediMaganer krediMaganer, ILoggerService loggerService)
        {
            //Başvuran bilgilerini degerlendirme
            //
            krediMaganer.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediMaganer> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }



    }
}
