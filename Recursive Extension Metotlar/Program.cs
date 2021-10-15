using System;

namespace Recursive_Extension_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            İslemler islem = new();
            
            Console.WriteLine(islem.Expo(3,4));

            string metin = "Ali ata bak";
            if(metin.CheckSpaces())
            {
                Console.WriteLine(metin.RemoveSpaces());
                Console.WriteLine(metin.MakeUpperCase());
                Console.WriteLine(metin.MakeLowerCase());
            }
                
               int[] sayılar = {2,5,1,4,3,74,54};
               
               int[] sortedSayılar = sayılar.ArraySort();
               sortedSayılar.EkranaYazdır();

               int c = 5;
               Console.WriteLine(c.IsEvenNumber());
               
                
            
        }
    }

    public class İslemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs<2)
                return sayi;
            return Expo(sayi,üs-1)*sayi;
            
        }
    }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveSpaces(this string param)
        {
            return string.Join("",param.Split(" "));
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] ArraySort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }
    }
}
