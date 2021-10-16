using System;

namespace Datetime_ve_Math_Sınıfları
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(4));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));

            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));



            //Math

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(90)); //sinüs alır
            Console.WriteLine(Math.Cos(180));
            Console.WriteLine(Math.Tan(0));

            Console.WriteLine(Math.Ceiling(22.3));  //22.3 ten büyük en küçük tam sayı
            Console.WriteLine(Math.Round(22.3));   //Hangi tam sayıya yakınsa o
            Console.WriteLine(Math.Round(22.3));
            Console.WriteLine(Math.Floor(22.7));   //22.7 den küçük en büyük tam sayı

            Console.WriteLine(Math.Min(5,10));
            Console.WriteLine(Math.Max(5,10));

            Console.WriteLine(Math.Pow(3,4)); //üs alma işlemi
            Console.WriteLine(Math.Sqrt(9));  // karekök alır
            Console.WriteLine(Math.Log(9));   //9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3));   //e üssü 3 verir
            Console.WriteLine(Math.Log10(10));//10 un 10 tabanındaki logaritmik karşılığı
            

        }
    }
}
