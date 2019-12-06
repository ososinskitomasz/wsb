using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pętle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i wynosi: {0}", i);
            }

            Console.WriteLine();

            //Napisz program, króry za pomocą pętli for sumuje liczby nieparzyste z przedziału od 1 do 10
            int s = 0;
            for (int l = 1; l <= 10; l++)
            {
                if (l % 2 != 0)
                {
                    s = s + l;
                }
            }

            Console.WriteLine("Suma liczb nieparzystych z przedziału od 1 do 10 to: {0}", s); //25
            Console.WriteLine();

            //Napisz program, który wyświetli wielkie litery alfabetu od A do Z oraz od Z do A z wykorzystaniem pętli for, np. "A, B, C, ... Z."; "Z, Y, X, ... A."
            char abc = 'A';
            for (abc = 'A'; abc <= 'Z'; abc++)
            {
                if (abc != 'Z')
                {
                    Console.Write("{0}, ", abc);
                }
                else
                {
                    Console.Write("{0}.", abc);
                }
            }

            Console.WriteLine("\n");

            for (char zyx = 'Z'; zyx >= 'A'; zyx--)
            {
                if (zyx != 'A')
                {
                    Console.Write("{0}, ", zyx);
                }
                else
                {
                    Console.Write("{0}.", zyx);
                }
            }

            Console.WriteLine("\n");

            /*Napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się w przedziale od 0 do 10,
             * oblicza wartość dla funkcji y = 4x
             */

            int whileX = 0;
            int whileY = 0;
            while (whileX <= 10)
            {
                whileY = whileX * 4;
                Console.WriteLine("x = {0}\ty = {1}", whileX, whileY);
                whileX++;
            }

            Console.WriteLine();

            /* Napisz program, który za pomocą pętli while dla danych wartości x zmieniających się w przedziale od 1 do 50,
             * obliczy ich sumę
             */

            s = 0;
            int x = 1;

            while (x <= 50)
            {
                s += x;
                x++;
            }

            Console.WriteLine(s); //1275
            Console.WriteLine();

            //Użytkownik podaje swój wiek w przedziale od 1 do 120. Wykorzystaj pętlę do...while do prawidłowego podania danych
            int w;
            do
            {
                Console.Write("Podaj swój wiek od 1 do 120: ");
                if (!int.TryParse(Console.ReadLine(), out w))
                {
                    Console.WriteLine("Błędne dane");
                }
            }
            while (w < 1 || w > 120);

            Console.WriteLine("Wiek: {0}", w);
            Console.WriteLine();

            //Wyświetl tabliczkę mnożenia za pomocą dwóch pętli do...while

            int n = 10;
            int row, col;

            row = 1;

            do
            {
                col = 1;
                do
                {
                    Console.Write(row * col + "\t");
                    //Console.Write("\t{0}", row * col);
                    col++;
                } while (col <= n);
                row++;
                Console.WriteLine();
            } while (row <= n);

            Console.WriteLine();

            //WIP//Tablica
            int[] tab = new int[9];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("{0}, ", tab[0]);
            }

            Console.ReadKey();
        }
    }
}
