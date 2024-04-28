using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math functions
            Console.WriteLine(Math.PI); // Pi sayısını verir.
            Console.WriteLine(Math.Abs(-10)); // Mutlak değer.
            Console.WriteLine(Math.Sqrt(25)); // Karekökünü alır.
            Console.WriteLine(Math.Pow(2,3)); // Üs alma
            Console.WriteLine(Math.Max(1,24)); // Büyük olanı bulma
            Console.WriteLine(Math.Min(1,24)); // Küçük olanı bulma
            // Yuvarlama
            Console.WriteLine(Math.Round(3.49)); // Tam yuvarlama
            Console.WriteLine(Math.Floor(3.99)); // Aşağı yuvarlama
            Console.WriteLine(Math.Ceiling(3.01)); // Yukarı yuvarlama


            Console.ReadLine();
        }
    }
}
