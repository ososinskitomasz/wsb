using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine("Zmienna x przed wywołaniem funkcji: {0}", x);
            Increment(ref x);
            Increment(ref x);
            Increment(ref x);

            Console.ReadKey();

        }

        static void Increment(ref int x)
        {
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}", x);
        }
    }
}
