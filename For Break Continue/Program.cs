using System;

namespace For_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz: ");
            int sayı = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayı; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


            int tekToplam = 0;
            int çiftToplam = 0;


            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 0)
                    çiftToplam += i;
                else
                    tekToplam += i;
            }

            Console.WriteLine("tektoplam = "+tekToplam);
            Console.WriteLine("çifttoplam = "+çiftToplam);

            for (int i = 0; i < 15; i++)
            {
                if(i == 4)
                    break;
                
                Console.WriteLine(i);
            }

            for (int i = 0; i < 15; i++)
            {
                if(i == 4)
                    continue;
                
                Console.WriteLine(i);
            }

        }
    }
}
