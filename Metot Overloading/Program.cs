using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayı = "99";
            bool kontrol = int.TryParse(sayı,out int outsayı);
            if (kontrol)
            {
                Console.WriteLine("başarılı");
                Console.WriteLine(outsayı);
            }
            else
            {
                Console.WriteLine("başarısız");
            }

            Metotlar metot = new Metotlar();
            metot.Topla(5,4,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int number = 987;
            metot.EkranaYazdır(number);
            metot.EkranaYazdır(sayı,sayı);

        }
    }

    class Metotlar
    {
        public void Topla(int x, int y, out int toplam)
        {
            toplam = x+y;
        }

        public void EkranaYazdır(string a)
        {
            Console.WriteLine(a);
        }

        public void EkranaYazdır(int a)
        {
            Console.WriteLine(a);
        }

        public void EkranaYazdır(string a,string b)
        {
            Console.WriteLine(a+b);
        }
    }
}
