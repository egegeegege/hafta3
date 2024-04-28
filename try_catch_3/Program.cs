using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("1. sayı");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2. sayı");
                int sayi2 = int.Parse(Console.ReadLine());

                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);

            }
            catch (Exception error) // DivideByZeroException olarak belirtirsek sadece sıfıra bölünme hatalarını yakalar.
			{
                Console.WriteLine($"Hata: {error}");
			}
            finally { // Hata olsada olmasada çalışır.
                Console.WriteLine("Her türlü çalışırım.");
            }

            Console.ReadLine();
        }
    }
}
