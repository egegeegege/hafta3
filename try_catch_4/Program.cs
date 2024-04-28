using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace try_catch_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Basla:
			try
			{
				Console.WriteLine("Sayı giriniz");
				int sayi = int.Parse(Console.ReadLine());
			}
			catch (Exception)
			{
				Console.WriteLine("Hata oluştu");
				Thread.Sleep(3000);
				goto Basla;
			}
			finally 
			{
				Console.WriteLine("İşlem gerçekleşti");	
			}

			Console.ReadLine();
        }
    }
}
