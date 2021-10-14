using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[10];

            string[] hayvanlar = {"kedi","köpek","kuş"};

            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";
            Console.WriteLine(hayvanlar[0]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            Console.WriteLine("Dizinin uzunluğunu giriniz: ");
            int uzunluk = int.Parse(Console.ReadLine());

            int[] sayılar = new int[uzunluk];

            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz: ",i+1);
                sayılar[i] = int.Parse(Console.ReadLine());
            } 
            
            int toplam = 0;
            foreach (var sayı in sayılar)
            {
                toplam += sayı;
            }

            Console.WriteLine("Sayıların ortalaması = {0}",toplam/sayılar.Length);

        }
    }
}
