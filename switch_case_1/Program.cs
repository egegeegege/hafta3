using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Haftanın kaçıncı günü (1-7)");
            int gun = int.Parse(Console.ReadLine());

            switch (gun)
            {
                case 1: Console.WriteLine("Pazartesi"); break;
                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Cumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default:  goto Start; break;
            }

            Console.ReadLine();
        }
    }
}
