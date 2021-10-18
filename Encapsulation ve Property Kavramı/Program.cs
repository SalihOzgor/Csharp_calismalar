using System;

namespace Encapsulation_ve_Property_Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Muhammet";
            ogrenci.Soyisim  = "Karaali";
            ogrenci.OgrenciNo = 254;
            ogrenci.Sinif = 4;

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgiler();

            Ogrenci ogrenci2 = new Ogrenci("Recep","Şahin",25,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgiler();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set
            { 
                if (value<1)
                {
                    Console.WriteLine("Sınıf en düşük '1' olabilir.");
                    sinif = 1;
                }else
                {
                    sinif = value;
                }
                
            } 
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}
        public void OgrenciBilgiler()
        {
            Console.WriteLine("Öğrenci ismi: {0}",this.Isim);
            Console.WriteLine("Öğrenci soyismi: {0}",this.Soyisim);
            Console.WriteLine("Öğrenci numarası: {0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıfı: {0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif += 1;
        }

        public void SinifDusur()
        {
            this.Sinif -= 1;
        }


        
    }
}
