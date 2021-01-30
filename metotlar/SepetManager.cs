using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("tebriks sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi , string Aciklama, double Fiyatı, int StokAdedi)
        {
            Console.WriteLine("tebriks sepete eklendi : " + urun.Adi);

        }
    }
}
