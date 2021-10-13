using System;

namespace Tip_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)

            float a; 
            int b = 25;
            a = b;
            Console.WriteLine("a: "+a);

            short x = 10; 
            int y; 
            y = x;
            Console.WriteLine("y: "+y);


            //Explicit Conversion (Bilinçli ya da açık dönüşüm)
            short c = 10; 
            int d = 9; 
            c = (short)d;
            Console.WriteLine("c: "+c);

            int f = 15;
            int g = 16;
            string f1 = f.ToString();
            string g1 = g.ToString();
            Console.WriteLine("f1 + g1: "+ (f1+g1));

            string h = "25";
            int h1 = Convert.ToInt32(h);

            int h2 = int.Parse(h);

            Console.WriteLine("h1 + h2: "+ (h1+h2));




            
        }
    }
}
