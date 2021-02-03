using System;

namespace Opp2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "111111111111";

            //kodlama.io


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "435455";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "22222222222";




            //gerçek müşteri - tüzel müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);








        }
    }
}
