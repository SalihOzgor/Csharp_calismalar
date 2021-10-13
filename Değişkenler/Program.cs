using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte sayı0 = 10; // daha da küçük sayılar...
            short sayı1 = 1000; // daha küçük sayılar, bellekte daha az yer.
            int sayı2 = 1000000;
            long sayı3 = 5000000000000; // daha büyük sayıları tutar , lakin bellekte daha çok yer kaplar.

            double sayı4 = 10.9;
            decimal sayı5 = 10.456456465465m; // virgülden sonra daha fazla rakam.
            float sayı6 = 3.3f;

            bool şart = true;
            char harf = 'a';

            string x1 = "3.4";

           double x2 = Convert.ToDouble(x1);
            
            Console.WriteLine("Sayılar: {0}, {1}", sayı2, sayı3);
            Console.WriteLine("Harf {0} ASKI değeri: {1}", harf, (int)harf);

            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));

            Console.WriteLine(DateTime.Now.ToString("HH.mm"));
            
        }
    }
}
