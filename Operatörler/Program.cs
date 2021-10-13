using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");


            //Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)

            int a = 1;
            a +=2;

            //Mantıksal Operatörler (||, &&, !)

            bool kontrol1 = true;
            bool kontrol2 = false;

            if(kontrol1 && !kontrol2)
            {
                Console.WriteLine("Harika");
            }

            //İlişkisel Operatörler (==,!=, <, >, >=,<=)

            int c = 5;
            int d = 6;

            Console.WriteLine(c<=d);

            //Aritmetik (+, -, *, /, %, ++, --)

            int x = 10;
            int y = 15;

            int z = x+y;
            Console.WriteLine(z);
        }
    }
}
