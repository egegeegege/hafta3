using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç karakterli bir şifre istersiniz:");
            int uzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Kaç tane şifre istersiniz:");
            int adet = int.Parse(Console.ReadLine());

            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&*@";

            Random random = new Random(); // instance (örneklem)
            for (int i = 0; i < adet; i++)
            {
                for (int j = 0; j < uzunluk; j++)
                {
                    Console.Write(characters[random.Next(0, characters.Length)]);
                }
                Console.WriteLine("\n");
            }
            

            Console.ReadLine();
        }
    }
}
