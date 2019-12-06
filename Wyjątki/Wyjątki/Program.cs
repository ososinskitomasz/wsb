using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            uint number;

            while (true)
            {
                Console.ResetColor();
                Console.Write("Wprowadź liczbę całkowitą: ");
                x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBłąd: {0}", e.Message);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPrawdiłowe dane: {0}", number);

            Console.ReadKey();
        }
    }
}
