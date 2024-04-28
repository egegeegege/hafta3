using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guid_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guid guid = Guid.NewGuid();  // Global benzersiz kimlik

            Console.WriteLine(guid);

            Console.ReadLine();
        }
    }
}
