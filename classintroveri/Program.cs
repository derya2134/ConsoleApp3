using System;

namespace classintroveri
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            kurs kurs1 = new kurs(); 
            kurs1.kursAdi = "c#";
            kurs1.egitmen = "engin demirog";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "kerem varıs";
            kurs2.IzlenmeOrani = 64;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "python";
            kurs3.egitmen = "berkay ah";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.egitmen);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
