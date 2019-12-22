using System;

namespace Funkcje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Napisz program, który sprawdza, czy liczba całkowita podana przez użytkownika jest parzysta/nieparzysta.
             * Napisz funkcję, która przyjmuje jako argument liczbę całkowitą podaną przez użytkownika z klawiatury.
             * Zabezpiecz program przed błędnie podanymi danymi z klawiatury.
             */

            Console.WriteLine("Podaj x: ");

            try
            {
                Liczba(0);
            }
            catch (SystemException blad)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(blad);
                Console.ResetColor();
            }

            Console.ReadKey();
        }

        static void Liczba(uint x)
        {

        }
    }
}
