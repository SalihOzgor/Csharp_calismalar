using System;

namespace Struct_Yapı__Kavramı
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine(dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct; //new'lenmeden kullanılabilirler
            dikdortgen_Struct.KisaKenar = 3;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine(dikdortgen_Struct.AlanHesapla());
            
        }
    }

    class Dikdortgen
    {
        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return KisaKenar*UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public Dikdortgen_Struct(int kisaKenar , int uzunKenar)   // parametresi olmayan constructor tanımlayamayız
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return KisaKenar*UzunKenar;
        }
    }
}
