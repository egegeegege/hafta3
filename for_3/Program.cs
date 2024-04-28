using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan aldığımız başlangıç ve bitiş değerlerine göre dönüş yapan döngüyü yazın
            Console.WriteLine("Başlangıç değerini giriniz");
            int basla = int.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş değerini giriniz");
            int bitis = int.Parse(Console.ReadLine());

            for (int i = basla; i <= bitis; i++)
            {
                Console.WriteLine($"{basla} - {bitis} sayı arasındakileri yazdırıyorum: {i}");
            }

            Console.ReadLine();
        }
    }
}
