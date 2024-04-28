using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // İç içe döngü
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("Birinci Döngü: {0} - İkinci Döngü: {1}",i,j);
                   
                }
                if (i == 5)
                {
                    break;  // kırma işi yapar ve scope un dışına atar.
                }
                Console.WriteLine("*************************");
            }

            Console.ReadLine();
        }
    }
}
