using System;

namespace Array_Sınıfı_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayıdizisi = {5,9,1,4,6,44,27,11};
            Console.WriteLine("Array sırasız");

            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

            Array.Sort(sayıdizisi);
            Console.WriteLine("Array sıralı");

            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

            Array.Clear(sayıdizisi,2,2);
            Console.WriteLine("Array Clear");

            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

            Array.Reverse(sayıdizisi);
            Console.WriteLine("Array Reverse");

            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

            Console.WriteLine("Array IndexOf");
            Console.WriteLine(Array.IndexOf(sayıdizisi,27));

            Console.WriteLine("Array Resize");
            Array.Resize<int>(ref sayıdizisi,9);
            sayıdizisi[8] = 99;

            foreach (var sayı in sayıdizisi)
            {
                Console.WriteLine(sayı);
            }

        }
    }
}
