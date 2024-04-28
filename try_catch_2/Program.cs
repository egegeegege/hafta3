using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Sayı giriniz");
                int sayi = int.Parse(Console.ReadLine()); // Hata verme olsalığı olan kod.
                Console.WriteLine(sayi);
            }
			catch (Exception error)
			{
                Console.WriteLine(error);
			}

            Console.ReadLine();
        }
    }
}
