using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            
            liste.Add(14);
            liste.Add("merhaba");
            liste.Add('c');
            liste.Add(2.4f);

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            string[] renkler = {"kırmızı","sarı"}; 
            liste.AddRange(renkler);   // içine her türlü collection atılabilir
            List<int> sayılar = new List<int>(){2,5,8};
            liste.AddRange(sayılar);

            Console.WriteLine("*******");

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            ArrayList listem = new ArrayList();
            
            listem.Add(14);
            listem.Add(20);
            listem.Add(12);
            listem.Add(2);

            listem.Sort();
            Console.WriteLine("*******");

            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(listem.BinarySearch(14));  //sıralanmış listelerde kullanılabilir

            listem.Reverse();

            listem.Clear();




        }
    }
}
