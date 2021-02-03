using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class TasitKrediMaganer : IKrediMaganer
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı");
        }
    }
}
