using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Name: "); //elooo
            Console.WriteLine("Tomasz");
            /*xddd
             * omg
             */

            /*
            string name = "Tomasz";
            string name1 = "Anna";
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your name is: {0}", name);

            int age = 25;
            sbyte age1 = 20;

            Console.WriteLine("His name = {0}, age = {1}", name, age);
            Console.WriteLine("Her name = {0}, age = {1}", name, age1);

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

            /*
            Console.WriteLine("Podaj długość boku a: ");
            string a = Console.ReadLine();

            uint numberUint;
            if (uint.TryParse(a, out numberUint) == true)
            {
                Console.WriteLine("\nPodaj długość boku b: ");
                string b = Console.ReadLine();

                if (uint.TryParse(b, out numberUint) == true)
                {
                    double pole = double.Parse(a) * double.Parse(b);
                    Console.WriteLine("Pole prostokąta wynosi: {0}", pole);
                    double obwod = (double.Parse(a) * 2) + (double.Parse(b) * 2);
                    Console.WriteLine("Obwód prostokąta wynosi: {0}", obwod);
                }
                else
                    Console.WriteLine("Podałeś błędne dane");
            }
            else
                Console.WriteLine("Podałeś błędne dane");
            */

            /*
            //CSLabs.pdf/1:
            float a, b;
            Console.WriteLine("Podaj liczbę a: ");
            if (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Podałeś błędne dane");
            }
            else
            {
                Console.WriteLine("Podaj liczbę b: ");
                if (!float.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Podałeś błędne dane");
                }
                else
                {
                    if (a == -b)
                    {
                        Console.WriteLine("Próba dzielenia przez zero");
                    }
                    else
                    {
                        float wynik = ((a * a) + b) / (a + b) * (a + b);
                        Console.WriteLine("Wartość wyrażenia wyonsi: {0}", wynik);
                    }
                }
            }
            */

            /*double a, b, c;
            Console.WriteLine("a: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Błędne dane");
            }
            else
            {
                Console.WriteLine("b: ");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Błędne dane");
                }
                else
                {
                    Console.WriteLine("c: ");
                    if (!double.TryParse(Console.ReadLine(), out c))
                    {
                        Console.WriteLine("Błędne dane");
                    }
                    else
                    {
                        if (a == -b)
                        {
                            Console.WriteLine("Próba dzielenia przez zero");
                        }
                        else
                        {
                            if (c > 0)
                            {
                                double wynik = (a * a) + b;
                                Console.WriteLine("a^2 + b: {0}", wynik);
                            }

                            else if (c < 0)
                            {
                                double wynik2 = a - (b * b);
                                Console.WriteLine("a - b^2: {0}", wynik2);
                            }

                            else
                            {
                                double wynik3 = 1 / (a - b);
                                Console.WriteLine("1 / a - b: {0}", wynik3);
                            }
                        }
                    }
                }
            }*/

            /*int[] liczby = new int[10]; //Deklaracja tablicy 10-elementowej liczb typu int

            for(int i = 0; i < 10; i++) //Wypełnienie tablicy
            {
                //liczby[i] = i * 2;
                Console.Write("Podaj wartość elementu liczby [{0}] = ", i);
                liczby[i] = int.Parse(Console.ReadLine());
            }

            for(int j = 0; j < 10; j++) //Wyświetlenie elementów tablicy
            {
                Console.WriteLine("Element tablicy liczby ["+j+"] = " + liczby[j]);
            }*/

            /*int[,] tablica2 = new int[3, 3];

            for(int w = 0; w < 3; w++) //Wypełnienie tablicy iloczynami indeksów
            {
                for(int k = 0; k < 3; k++)
                {
                    tablica2[w, k] = w * k;
                }
            }

            for(int w = 0; w < 3; w++)
            {
                for(int k = 0; k < 3; k++)
                {
                    Console.WriteLine("Element [{0}, {1}] = {2}", w, k, tablica2[w, k]);
                }
            }*/

            /*Console.Write("Podaj liczbę wierszy tablicy: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę wierszy kolumn: ");
            int n = int.Parse(Console.ReadLine());

            int[,] tablica3 = new int[m, n];

            for(int w = 0; w < m; w++) //Wypełnienie tablicy iloczynami indeksów
            {
                for(int k = 0; k < n; k++)
                {
                    tablica3[w, k] = w * k;
                }
            }

            for(int w = 0; w < m; w++)
            {
                for(int k = 0; k < n; k++)
                {
                    Console.Write("{0} \t", tablica3[w, k]);
                }
                Console.WriteLine("");
            }*/

            //CSLabs.pdf/Zadanie 7:
            Console.Write("Podaj stopień macierzy: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę wierszy tablicy: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę wierszy kolumn: ");
            int n = int.Parse(Console.ReadLine());

            int[,] tablica4 = new int[s, s];

            for (int w = 0; w < s; w++) //Wypełnienie tablicy iloczynami indeksów
            {
                for (int k = 0; k < s; k++)
                {
                    tablica4[w, k] = w * k;
                }
                //if()
                {

                }
            }

            for (int w = 0; w < s; w++)
            {
                for (int k = 0; k < s; k++)
                {
                    Console.Write("{0} \t", tablica4[w, k]);
                }
                Console.WriteLine("\n");
                //if()
                {

                }
            }

            //Console.WriteLine("Suma elementów powyżej głównej przekątnej ({0}) nie jest większa od sumy elementów poniżej głównej przekątnej ({1}).", powyzej, ponizej);

            Console.ReadKey();
        }
    }
}
