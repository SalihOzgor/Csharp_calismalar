using System;

namespace If_Else_Yapısı_ve_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time<11)
                Console.WriteLine("Günaydın");
            else if(time<18)
                Console.WriteLine("İyi Günler");
            else
                Console.WriteLine("İyi Akşamllar");

            string sonuc = time<18 ? "İyi Günler" : "İyi Akşamlar";

            string sonuc2 = time >= 6 && time<11 ? "İyi Günler" : time<18 ? "İyi Günler" : "İyi Akşamllar";

            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);

        }
    }
}
