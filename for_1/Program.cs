using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For Döngüsü
            /* 
             Yapı
             for(int i = 0; i < 10 ; i++){   değer tanımı ; koşul ; artış yada azalış miktarı
            
            
             }
             
             
             */

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello!");
            }
            Console.WriteLine("******************");
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Hello!");
            }
            Console.WriteLine("******************");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******************");
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******************");
            for (int i = 1; i < 5; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
