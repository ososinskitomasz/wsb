using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który wyświetli ciąg znaków o określonej długości.
             * Podaj liczbę znaków "*" oraz "#", które mają być wyświetlone.
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witamy w kreatorze ciągu znaków.");
            Console.ResetColor();

            uint l, a, h;

            while (true)
            {
                Console.WriteLine("Jak długi ma być ciąg?");

                try
                {
                    l = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (SystemException blad)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(blad);
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.WriteLine("Ile ma być gwiazdek *?");

                try
                {
                    a = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (SystemException blad)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(blad);
                    Console.ResetColor();
                }
            }

            while (true)
            {
                Console.WriteLine("Ile ma być hashy #?");

                try
                {
                    h = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (SystemException blad)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(blad);
                    Console.ResetColor();
                }
            }

            for (uint i = 0; i < l; i++)
            {
                if (i % (a + h) < a)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("#");
                }
            }

            Console.ReadKey();
        }
    }
}
