using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(10,"Ali");
            kullanıcılar.Add(12,"Veli");
            kullanıcılar.Add(8,"Mehmet");
            kullanıcılar.Add(14,"Ayşe");


            Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kullanıcılar.Count);

            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Salih"));
            

            kullanıcılar.Remove(8);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
