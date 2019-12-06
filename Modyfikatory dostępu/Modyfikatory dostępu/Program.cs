using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modyfikatory_dostępu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Modyfikatory dostępu";
            Console.WriteLine("WSB");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WSB");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tWSB\t");
            Console.ResetColor();
            Console.WriteLine("WSB");

            Console.ReadKey();
        }
    }
}
