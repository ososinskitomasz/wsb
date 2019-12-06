using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Użytkownik podaje z klawiatury dane dwóch boków
             * Oblicz pole prostokąta i obwód
             *
             * Wyświetl w formacie:
             * Pole prostokąta wynosi: ...
             * Obwód prostokąta wynosi: ...
             *
             * Sprawdź czy dane z klawiatury są poprawne
             * W przypadku błędnych danych wyświetl na ekranie komunikat:
             * "Podałeś błędne dane"
             */
            Console.WriteLine("OBLICZANIE POLA ORAZ OBWODU PROSTOKĄTA");
            Console.Write("Podaj a: ");
            string a = Console.ReadLine();

            uint czyUint;
            if (uint.TryParse(a, out czyUint) == true)
            {
                Console.Write("Podaj b: ");
                string b = Console.ReadLine();
                if (uint.TryParse(b, out czyUint) == true)
                {
                    float pole = float.Parse(a) * float.Parse(b);
                    Console.WriteLine("Pole prostokąta o długościach boków {0} i {1}: {2}", a, b, pole);

                    float obwod = (float.Parse(a) * 2) + (float.Parse(b) * 2);
                    Console.WriteLine("Obwód prostokąta o długościach boków {0} i {1}: {2}", a, b, obwod);

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Podano błędne dane!");

                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Podano błędne dane!");

                Console.ReadKey();
            }

            /*
             * Write a C# Sharp program to check whether a given number is even or odd.
             * https://www.w3resource.com/csharp-exercises/conditional-statement/index.php
             */
            Console.WriteLine("\nSPRAWDZANIE, CZY PODANA LICZBA JEST PARZYSTA CZY NIE");
            Console.Write("Podaj liczbę: ");
            string a2 = Console.ReadLine();

            int czyInt;
            if (int.TryParse(a2, out czyInt) == true)
            {
                if (int.Parse(a2) % 2 == 0)
                {
                    Console.WriteLine("Liczba {0} jest parzysta.", a2);

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Liczba {0} nie jest parzysta.", a2);

                    Console.ReadKey();
                }
            }

            //Wyświetl zawartość tablicy za pomocą dwóch pętli for
            Console.WriteLine("\nWYŚWIETLANIE ZAWARTOŚCI TABLICY");
            int[][] tablicaNieregularna = new int[3][]
            {
                new int[] {1, 2},
                new int[] {3, 4, 5},
                new int[] {6}
            };

            Console.WriteLine("Długość tablicy: " + tablicaNieregularna.Length);

            for (int i = 0; i < tablicaNieregularna.Length; i++)
            {
                for (int j = 0; j < tablicaNieregularna[i].Length; j++)
                {
                    Console.Write(tablicaNieregularna[i][j]);
                }
                Console.WriteLine();
            }

            string[][] tablicaNieregularna2 = new string[4][]
            {
                new string[] {"*"},
                new string[] {"*", "*"},
                new string[] {"*", "*", "*"},
                new string[] {"*", "*", "*", "*"}
            };

            Console.WriteLine("Długość drugiej tablicy: ", tablicaNieregularna2.Length);

            for (int i = 0; i < tablicaNieregularna2.Length; i++)
            {
                for (int j = 0; j < tablicaNieregularna2[i].Length; j++)
                {
                    Console.Write(tablicaNieregularna2[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
