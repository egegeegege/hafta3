using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10000 arasında 13 ün katları olan sayıların kaç adet olduğunu bul ve toplamlarını göster.
            int count = 0;
            int toplam = 0;
            for (int i = 13; i <= 100; i+=13)
            {
                count++;
                toplam = toplam + i;
            }

            Console.WriteLine($"1-100 arasında 13 ün katı {count} kadardır. Toplamları: {toplam}");

            Console.ReadLine();
        }
    }
}
