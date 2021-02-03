using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediMaganer : IKrediMaganer
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}
