using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) 
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.25;
            double dolarBugun = 7.25;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else

            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar butonu");                                                  
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }       
    }
}
