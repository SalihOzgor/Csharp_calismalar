using System;

namespace String_Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            string metin = "ali ata bak";
            string metin2 = "metin2 oynadım";
            Console.Write(metin.Length);
            Console.WriteLine(metin.ToUpper());
            Console.WriteLine(metin.ToLower());
            Console.WriteLine(string.Concat(metin," lütfen"));

            Console.WriteLine(metin.CompareTo(metin2));  // karakter sayısı eşi ise 0 , büyük ise 1 , küçük ise -1
            Console.WriteLine(string.Compare(metin,metin2,true));

            Console.WriteLine(metin.Contains("ata"));
            Console.WriteLine(metin.EndsWith("bak"));
            Console.WriteLine(metin.StartsWith("ata"));
            Console.WriteLine(metin.IndexOf("ta"));
            Console.WriteLine(metin.LastIndexOf("a"));
            Console.WriteLine(metin.Insert(0,"merhaba! "));


            Console.WriteLine(metin+metin2.PadLeft(30));
            Console.WriteLine(metin+metin2.PadRight(20,'*')+metin);

            Console.WriteLine(metin.Remove(5,4));
            Console.WriteLine(metin.Replace("ali","veli"));

            Console.WriteLine(metin.Split(" ")[0]);

            Console.WriteLine(metin.Substring(2,6));


        }
    }
}
