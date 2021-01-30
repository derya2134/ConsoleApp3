using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double Fiyati = 15;
            string Aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Acikmala = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Acikmala = "diyarbakır karpouzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acikmala);
                Console.WriteLine("........");

            }

            Console.WriteLine("---------metotlar-------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 30);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 28);

        }
    }
}


