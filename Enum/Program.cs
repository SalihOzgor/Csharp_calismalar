using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);
            Console.WriteLine("Sıcaklık değerini giriniz: ");
            int sicaklik = int.Parse(Console.ReadLine());

            if (sicaklik < (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hava Soğuk");
            }
            else if (sicaklik < (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Hava Ilık");
            }
            else if (sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hava Sıcak");
            }
            else
            {
                Console.WriteLine("Hava Çok Sıcak");
            }

        }
    }

    enum Gunler
    {
        Pazartesi = 1, // default u 0 dır. yani sıfırdan saymaya  başlar.
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
