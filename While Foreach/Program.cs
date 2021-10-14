using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz: ");
            int sayı = int.Parse(Console.ReadLine());
            int sayaç = 1;
            int toplam = 0;
            
            while (sayaç<=sayı)
            {
                 toplam += sayaç;
                 sayaç++;
            }
            Console.WriteLine(toplam/sayı);

            char harf = 'a';

            while (harf<='z')
            {
                 Console.Write(harf);
                 harf++;
            }


            string[] arabalar = {"Audi","BMW","Mercedes","Honda"};
            foreach (string araba in arabalar)
            {
                Console.Write("\n"+araba);
            }
        }
    }
}
