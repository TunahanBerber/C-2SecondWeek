using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Progrmalamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Progrmalamaya başlangıç için temel kurs",
                "Java"
            };

            for (int i = 0; i < kurslar.Length; i++)  //i sayaç anlamına geliyor
            {
                Console.WriteLine(kurslar[i]);                
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)  //kursları dolaş demek
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
