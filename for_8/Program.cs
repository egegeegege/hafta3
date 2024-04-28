using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace for_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Hoşgeldiniz. Sayısal Loto sayılarınız üretiliyor....");
            Thread.Sleep(1000);

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("{0}. şanslı sayı: {1}", i, rnd.Next(1, 50));
                Thread.Sleep(rnd.Next(1000, 4000));
            }
            // ctrl + k + d => prettier kodu otomatik düzenleme
            Console.ReadLine();
        }
    }
}
