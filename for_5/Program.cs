using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çarpım tablosu

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} Çarpımları");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||");
            }

            Console.ReadLine();
        }
    }
}
