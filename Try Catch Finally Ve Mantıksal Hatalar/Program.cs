using System;

namespace Try_Catch_Finally_Ve_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {

            // try
            // {
            //     Console.WriteLine("Bir sayı giriniz: ");
            //     int sayı = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Sayı = "+ sayı);
            // }
            // catch (Exception ex)
            // {
            //     
            //     Console.WriteLine("Hata: "+ ex.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem tamamlandı");
            // }


            try
            {
                
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-33333333333333333");
                
            }
            catch (ArgumentNullException ex)
            {
                
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("Veri tip uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                
                Console.WriteLine("Değer çok küçük ya da çok büyük");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
        }
    }
}
