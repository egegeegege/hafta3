using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Functions (Metinsel Fonksiyonlar)
            string metin = "Üçüncübin";
            string metin2 = "Yıl";
            Console.WriteLine(metin.Length); // Metnin uzunluğunu gösterir.
            Console.WriteLine(metin.ToLower()); // Küçük Harf
            Console.WriteLine(metin.ToUpper()); // Büyük Harf
            string merge = string.Concat(metin," ",metin2);
            Console.WriteLine(merge);
            int indexOfNo = metin.IndexOf('n'); // index of metindeki aradığımız ifadenin kaçıncı indexte olduğunu verir ve ilk bulduğu elemanın indexini gösterir.
            Console.WriteLine(indexOfNo);
            int lastIndexOfNo = metin.LastIndexOf('ü'); // last index of metindeki aradığımız ifadenin kaçıncı indexte olduğunu sondan başlayıp arayarak verir ve ilk bulduğu elemanın indexini gösterir.
            Console.WriteLine(lastIndexOfNo);

            string sub = metin.Substring(0, metin.Length); // başlangıç indexinden istediğimiz uzunluk kadar metni almamızı sağlar.
            Console.WriteLine(sub);

            bool VarMi = metin.Contains("bin"); // Containsel metinsel ifade içinde başka bir ifadeyi aramaya yarar ve bulursa True bulamazsa False sonucunu döner.
            Console.WriteLine(VarMi);

            string repl = metin.ToLower().Replace("bin", "ikibin");  // replace ilk parametresi aradığımız ifade ikinci parametresi değiştirmek istediğimiz ifade olmak üzere 2 parametre alır ve bunun sonucunda metni değiştirir. 2 aşırı yüklemesi vardır char da alabilir stringte.

            Console.WriteLine(repl);

            

            Console.ReadLine();
        }
    }
}
