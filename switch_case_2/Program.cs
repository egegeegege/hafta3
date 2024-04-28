using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcdan 5 lik sistemde 2 adet not bilgisi isteyeceğiz. Ortalamaya kötü,orta, iyi değerlerini bize verecek switch case yapısını oluşturacağız.
            Console.WriteLine("1. notunuzu giriniz");
            int not1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. notunuzu giriniz");
            int not2 = int.Parse(Console.ReadLine());

            double ortalama = (not1 + not2) / 2;

            //switch (ortalama)
            //{
            //    case 1: Console.WriteLine("Çok Kötü"); break;
            //    case 2: Console.WriteLine("Kötü"); break;
            //    case 3: Console.WriteLine("Orta"); break;
            //    case 4: Console.WriteLine("İyi"); break;
            //    case 5: Console.WriteLine("Pekiyi"); break;
            //}

            switch (ortalama)
            {
                case 1:
                case 2: 
                    Console.WriteLine("Kötü"); break;
                case 3:
                case 4: 
                    Console.WriteLine("İyi"); break;
                case 5: 
                    Console.WriteLine("Pekiyi"); break;
            }

            Console.ReadLine();


        }
    }
}
