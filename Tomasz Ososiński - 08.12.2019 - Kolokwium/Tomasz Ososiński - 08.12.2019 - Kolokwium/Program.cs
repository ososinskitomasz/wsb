using System;

namespace Tomasz_Ososiński___08._12._2019___Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("WSB - kolokwium nr 1, Tomasz Ososińśki\n");
            Console.ResetColor();

            uint a, b, wiek;

            while (true)
            {
                Console.WriteLine("Podaj długość boku a prostokąta: ");

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
                Console.WriteLine("Podaj długość boku b prostokąta: ");

                try
                {
                    b = uint.Parse(Console.ReadLine());
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
                Console.WriteLine("Podaj wiek: ");

                try
                {
                    wiek = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (SystemException blad)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(blad);
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
            uint lCD, pole, stopien, x;

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Menu główne:");
                    Console.WriteLine("1. Pole prostokąta");
                    Console.WriteLine("2. Wyświetl, czy wiek jest liczbą parzystą");
                    Console.WriteLine("3. Macierz");
                    Console.WriteLine("4. Funkcja");
                    Console.WriteLine("0. Wyjdź");

                    try
                    {
                        x = uint.Parse(Console.ReadLine());
                        break;
                    }
                    catch (SystemException blad)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(blad);
                        Console.ResetColor();
                    }
                }

                switch (x)
                {
                    case 1:
                        Console.Clear();
                        pole = a * b;
                        Console.WriteLine("Bok a: " + a);
                        Console.WriteLine("Bok b: " + b);
                        Console.WriteLine("Pole prostokąta: " + pole);
                        break;
                    case 2:
                        if (wiek % 2 == 0)
                        {
                            Console.WriteLine("Wiek {0} jest liczbą parzystą.", wiek);

                        }
                        else
                        {
                            Console.WriteLine("Wiek {0} nie jest liczbą parzystą.", wiek);
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.WriteLine("Podaj stopień macierzy: ");

                            try
                            {
                                stopien = uint.Parse(Console.ReadLine());
                                break;
                            }
                            catch (SystemException blad)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(blad);
                                Console.ResetColor();
                            }
                        }

                        int[] macierz = new int[stopien * stopien];

                        for (int i = 1; i < stopien + 1; i++)
                        {
                            for (int j = 1; j < stopien + 1; j++)
                            {
                                macierz[j] = j;

                                if (j == stopien)
                                {
                                    Console.Write("WSB");
                                }

                                if (j != stopien)
                                {
                                    Console.Write(macierz[j] + (stopien * (i - 1)) + "  ");
                                }
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine("Suma liczb (nie licząc WSB wynosi " + ((stopien * stopien) - stopien));
                        break;
                    case 4:
                        while (true)
                        {
                            Console.WriteLine("Podaj liczbę całkowitą dodatnią: ");

                            try
                            {
                                lCD = uint.Parse(Console.ReadLine());
                                break;
                            }
                            catch (SystemException blad)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(blad);
                                Console.ResetColor();
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Twoja szczęśliwa liczba to: " + lCD);
                        Console.ResetColor();

                        break;
                    case 0:
                        break; ;

                }

                if (x == 0)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}