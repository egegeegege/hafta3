using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* 
         kullanıcıdan alınan cinsiyet bilgisine göre (E,e,K,k,Kadın,kadın);
         kullanıcının maaşı istenecek, yaşı istenecek, çalıştığı gün sayısı istenecek.
         eğer erkek ise =>
            eğer yaşı 60'ın üzerinde ise maaşının 10 katı ikaramiye verilerek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
            eğer yaşı 60'ın altında ise çalıştığı gün sayısı 6000'in üstünde ise maaşının 11 katı verilecek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
            eğer yaşı 60'ın altında ve çalıştığı gün sayısı 6000'in altında ise emekli olamadınız mesajı verilecek.
         eğer kadın ise =>
            eğer yaşı 55'ın üzerinde ise maaşının 10 katı ikaramiye verilerek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
            eğer yaşı 55'ın altında ise çalıştığı gün sayısı 5000'in üstünde ise maaşının 11 katı verilecek emekli edilecek ve emekli oldunuz şu kadar ikramiye aldınız mesajı verilecek.
            eğer yaşı 55'ın altında ve çalıştığı gün sayısı 5000'in altında ise emekli olamadınız mesajı verilecek.

         */
        // switch case => cinsiyet kontrolü
        // if ler => yaş ve gün sayısı kontrolü
        // try catch => hata ayıklama

            Start:
            try
            {
                Console.WriteLine("Lütfen cinsiyetinizi giriniz");
                string cinsiyet = Console.ReadLine();
                Console.WriteLine("Lütfen Maaşınızı giriniz giriniz");
                int maas = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen Yaşınızı giriniz");
                int yas = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen gün sayınızı giriniz giriniz");
                int gun = int.Parse(Console.ReadLine());

                string gender = (cinsiyet);

                switch (gender)
                {
                    case "e":
                    case "E":
                    case "erkek":
                    case "Erkek":
                        if (yas >= 60)
                        {
                            Console.WriteLine($"emekli oldunuz {maas * 10} kadar ikramiye aldınız ");
                        }

                        else if (yas < 60 && gun > 6000)
                        {
                            Console.WriteLine($"emekli oldunuz {maas * 11} kadar ikramiye aldınız ");
                        }

                        else if (yas < 60 && gun < 6000)
                        {
                            Console.WriteLine("emekli olamadınız mesajı verilecek");
                        }

                        else
                        {
                            Console.WriteLine("lütfen geçerli bir koşul giriniz");
                        }

                        break;

                    case "k":
                    case "K":
                    case "kadın":
                    case "Kadın":
                        if (yas >= 55)
                        {
                            Console.WriteLine($"emekli oldunuz {maas * 10} kadar ikramiye aldınız ");
                        }

                        else if (yas < 55 && gun > 5000)
                        {
                            Console.WriteLine($"emekli oldunuz {maas * 11} kadar ikramiye aldınız ");
                        }

                        else if (yas < 55 && gun < 5000)
                        {
                            Console.WriteLine("emekli olamadınız mesajı verilecek");
                        }

                        else
                        {
                            Console.WriteLine("lütfen geçerli bir koşul giriniz");
                        }

                        break;

                    default: Console.WriteLine("Doğru Ve Geçerli Bir Cinsiyet Giriniz"); break;
                }

            }

            catch (Exception)
            {
                Console.WriteLine("Hata meydana geldi tekrar deneyin");
                goto Start;
            }
            Console.ReadLine();

        }
    }
}
