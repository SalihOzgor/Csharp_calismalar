using System;

namespace Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır("merhaba");

            ornek.EkranaYazdır(Convert.ToString(a+b));
            ornek.EkranaYazdır(Convert.ToString(ornek.ArttırveTopla(ref a,ref b)));
            ornek.EkranaYazdır(Convert.ToString(a+b));

        }

        static int Topla(int a, int b){
            return a+b;
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string yazı)
        {
            Console.WriteLine(yazı);
        }

        public int ArttırveTopla(ref int x,ref int y)
        {
            x++;
            y++;
            return x+y;
        }
    }
}
