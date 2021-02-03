using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediMaganer : IKrediMaganer
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
