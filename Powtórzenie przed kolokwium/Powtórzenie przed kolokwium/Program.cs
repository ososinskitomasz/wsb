using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powtórzenie_przed_kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz program, który oferuje następujące możliwości:
             * 1. Rysowanie wieży o podanej przez użytkownika wysokości
             * 2. Kalkulator
             * 3. Opcje kolorowania konsoli oraz wieży
             */

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witamy w kreatorze wież.");
            Console.ResetColor();

            uint w, h;
            string kolor;

            while (true)
            {
                Console.WriteLine("Jak szeroka ma być wieża?");
                
                try
                {
                    w = uint.Parse(Console.ReadLine());
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
                Console.WriteLine("Jak wysoka ma być wieża?");

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

            /*while (true)
            {
                Console.WriteLine("Jakiego koloru ma być wieża?");
                kolor = Console.ReadLine();

                if (kolor == "czerwony" || kolor == "zolty" || kolor == "zielony" || kolor == "niebieski" || kolor == "bialy")
                {
                    switch (kolor)
                    {
                        case "czerwony":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "zolty":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "zielony":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "niebieski":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case "bialy":
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Nie ma takiego koloru!");
                }
            }
            */

            string[] dach = new string[w + 2];//Dach
            for (int i = 0; i < w + 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                dach[i] = "/\\";
                Console.Write(dach[i]);
            }
            Console.ResetColor();
            Console.WriteLine();

            string[] wieza = new string[h];//Wieza
            for (int i = 0; i < h; i++)
            {
                Console.Write("  ");
                for (int j = 0; j < w; j++)
                {
                    wieza[i] = "[]";
                    Console.Write(wieza[i]);
                }
                Console.WriteLine();
            }

            string[] ziemia = new string[w + 2];//Ziemia
            for (int i = 0; i < w + 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ziemia[i] = "##";
                Console.Write(ziemia[i]);
            }
            Console.ResetColor();
    
            Console.ReadKey();
        }
    }
}
