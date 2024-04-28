using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖDEV => Kullanıcıdan ilk olarak kullanıcı adı ve daha sonra şifre istenecek.
            // Eğer kullanıcı adı admin ve şifre 12345 ise sisteme giriş yapıldı Uyarısı gösterilecek.
            // Eğer kullanıcı adı veya şifre boş girildiyse lütfen boş girmeyiniz uyarısı verilecek.
            // Eğer kullanıcı adı ve şifre yanlış ise Kullanıcı bulunamadı uyarısı verilecek.

            Console.WriteLine("Kullanıcı adınızı giriniz");
            string kad = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            string pass = Console.ReadLine();

            if (kad == "admin" && pass =="12345")
            {
                Console.WriteLine($"{kad} sisteme hoşgeldiniz.");
            }
            else
            {
                if(kad == "" || pass == "")
                {
                    Console.WriteLine("Lütfen boş yapmayın");
                }
                else if (kad != "admin")
                {
                    Console.WriteLine("Kullanıcı adınız yanlış");
                }
                else if(pass != "12345")
                {
                    Console.WriteLine("Parolanız yanlış");
                }
            }

            Console.ReadLine();
        }
    }
}
