using System;

namespace Powtórzenie_na_kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Napisz program, który wyznaczy n elementów ciągu Fibonacciego i zapisze je do tablicy
             * Wyświetl przedział k-y o długości x
             * Sprawdź, czy podane dane są poprawne
             */

            string dCF;
            uint lN, c;
            uint a = 1;
            uint b = 1;

            while (true)
            {
                Console.WriteLine("Podaj długość ciągu Fibonacciego: ");
                dCF = Console.ReadLine();

                try
                {
                    lN = uint.Parse(dCF);

                    if (lN > 1)
                    {
                        uint[] tablica = new uint[lN];
                        tablica[0] = 1;
                        tablica[1] = 1;

                        for (uint i = 2; i < lN; i++)
                        {
                            c = a + b;
                            a = b;
                            b = c;

                            tablica[i] = c;
                        }

                        Console.WriteLine("Ciąg Fibonacciego:");

                        for (uint i = 0; i < lN; i++)
                        {
                            Console.WriteLine(tablica[i]);
                        }

                        while (true)
                        {
                            Console.Write("Podaj początkowy indeks ciągu: ");
                            string min = Console.ReadLine();

                            try
                            {
                                uint minInt = uint.Parse(min);

                                while (true)
                                {
                                    Console.Write("\nPodaj końcowy indeks ciągu ");
                                    string max = Console.ReadLine();

                                    try
                                    {
                                        uint maxInt = uint.Parse(max);
                                        for (uint i = minInt - 1; i < maxInt; i++)
                                        {
                                            Console.WriteLine(tablica[i]);
                                        }
                                        break;
                                    }
                                    catch (SystemException blad)
                                    {
                                        Console.WriteLine("Błąd: " + blad.Message);

                                        Console.ReadKey();
                                    }
                                }
                                break;
                            }
                            catch (SystemException blad)
                            {
                                Console.WriteLine("Błąd: " + blad.Message);

                                Console.ReadKey();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ciąg musi być dłuższy niż " + dCF);

                        Console.ReadKey();
                    }

                    Console.ReadKey();

                    break;
                }
                catch (SystemException blad)
                {
                    Console.WriteLine("Błąd: " + blad.Message);

                    Console.ReadKey();
                }

                Console.ReadKey();
            }
        }
    }
}
