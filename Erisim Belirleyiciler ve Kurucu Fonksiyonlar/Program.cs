using System;

namespace Erisim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.İsim = "Ayşe";
            calisan1.Soyisim = "Karaali";
            calisan1.No = 54216584;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan("Muhammet","Karaali",087425468,"Halkla İlişkiler");

            Calisan calisan3 = new Calisan("Onur","Alper");
            
            calisan2.CalisanBilgileri();
            calisan3.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public Calisan(string isim,string soyisim, int no, string departman)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(){}
        public string İsim;
        public string Soyisim;
        public int No;
        public string Departman;

        public Calisan(string isim,string soyisim)
        {
            this.İsim = isim;
            this.Soyisim = soyisim;
        }
        

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın ismi: {0}",İsim);
            Console.WriteLine("Çalışanın soyismi: {0}",Soyisim);
            Console.WriteLine("Çalışanın numarası: {0}",No);
            Console.WriteLine("Çalışanın departmanı: {0}",Departman);
        }
    }
}
