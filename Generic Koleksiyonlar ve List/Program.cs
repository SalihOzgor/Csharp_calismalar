using System;
using System.Collections.Generic;

namespace Generic_Koleksiyonlar_ve_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(15);
            sayilar.Add(51);
            sayilar.Add(41);
            sayilar.Add(24);
            sayilar.Add(12);
            sayilar.Add(13);
            sayilar.Add(4);
            sayilar.Add(10);

            List<string> renkler = new List<string>();
            renkler.Add("Kırmızı");
            renkler.Add("Yeşil");
            renkler.Add("Sarı");
            renkler.Add("Mavi");
            renkler.Add("Mor");
            renkler.Add("Turuncu");

            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }

            sayilar.ForEach(sayi=>Console.WriteLine(sayi));   //foreach
            renkler.ForEach(renk=>Console.WriteLine(renk));


            sayilar.Remove(4);
            renkler.Remove("Yeşil");

            sayilar.ForEach(sayi=>Console.WriteLine(sayi));  
            renkler.ForEach(renk=>Console.WriteLine(renk));

            sayilar.RemoveAt(0);  // verilen indexteki elemanı çıkarır
            renkler.RemoveAt(1);

            sayilar.ForEach(sayi=>Console.WriteLine(sayi));  
            renkler.ForEach(renk=>Console.WriteLine(renk));

            if (sayilar.Contains(51))
            {
                Console.WriteLine("51 VAR");
            }

            if (renkler.Contains("Turuncu"))
            {
                Console.WriteLine("Turuncu VAR");
            }

            Console.WriteLine(renkler.BinarySearch("Kırmızı"));  // o değerin hangi indexte olduğunu gösteriyor

            string[] hayvanlar = {"kedi","köpek","maymun","kuş"};
            List <string> hayvanList = new List<string>(hayvanlar); //hayvanlar listesindeki elemanlar ile hayvanList oluşturdu

            hayvanList.Clear();

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ahmet";
            kullanıcı1.Soyisim = "Ahmedov";
            kullanıcı1.Yaş = 22;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Soyisim = "Çayır";
            kullanıcı2.Isim = "Esma";
            kullanıcı2.Yaş = 24;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Osman",
                Soyisim = "Osmanoğlu",
                Yaş = 20
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine(kullanıcı.Isim);
                Console.WriteLine(kullanıcı.Soyisim);
                Console.WriteLine(kullanıcı.Yaş);
            }
        }
    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yaş;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yaş { get => yaş; set => yaş = value; }

        
    }
}
