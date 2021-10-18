using System;

namespace Sınıf_Nedir_Instance_Field_Property
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

            Calisan calisan2 = new Calisan();
            calisan2.İsim = "Muhammet";
            calisan2.Soyisim = "Karaali";
            calisan2.No = 61845324;
            calisan2.Departman = "Halkla İlişkiler";
            calisan2.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string İsim;
        public string Soyisim;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın ismi: {0}",İsim);
            Console.WriteLine("Çalışanın soyismi: {0}",Soyisim);
            Console.WriteLine("Çalışanın numarası: {0}",No);
            Console.WriteLine("Çalışanın departmanı: {0}",Departman);
        }
    }
}
