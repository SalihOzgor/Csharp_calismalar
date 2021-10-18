using System;

namespace Static_Sınıf_ve_Uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı= {0}",Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("Recep","Şahin","İK");
            Console.WriteLine("Çalışan sayısı= {0}",Calisan.CalisanSayisi);
            Console.WriteLine("Toplam = {0}", İslemler.Topla(5,8));

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }

        private string İsim;
        private string Soyİsim;
        private string Departman;

        static Calisan()       // static constructorların erişim belirteci olmaz
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim ,string soyisim ,string departman)
        {
            this.İsim = isim;
            this.Soyİsim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class İslemler
    {
        public static long Topla(long a, long b){
            return a+b;
        }

        public static long Cikar(long a, long b){
            return a+b;
        }
    }
    
}
