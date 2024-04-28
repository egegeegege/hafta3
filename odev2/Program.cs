using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan fiyat bilgisi ve ürün kategorisi istenecek. Eğer ürün kategorisi elektronik ise fiyata
            // %22 kdv uygulanıp yeni fiyat gösterilecek Eğer ürün kategorisi gıda ise fiyata %20 kdv uygulanıp gösterilecek. Kategori bunlar dışında bir kategori ise ürüne %23 kdv uygulanıp ödenmesi gerek fiyat gösterilecek.

            Console.WriteLine("Fiyat giriniz");
            double fiyat = double.Parse(Console.ReadLine());
            Console.WriteLine("Kategori giriniz");
            string kategori = Console.ReadLine();
            double sonFiyat = 0;

            if(kategori == "elektronik")
            {
                sonFiyat = fiyat * 1.22;
            }
            else if (kategori == "gıda")
            {
                sonFiyat = fiyat * 1.20;
            }
            else
            {
                sonFiyat = fiyat * 1.23;
            }

            Console.WriteLine($"Ödeyeceğiniz kdv li fiyat: {sonFiyat}");

            Console.ReadLine();

        }
    }
}
