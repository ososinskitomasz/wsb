using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wyszukiwanie liczb pierwszych z wykorzystaniem sita Erastotenesa - tablica boolowska
            int x;
            Console.Write("Podaj liczbę: ");
            uint liczba = uint.Parse(Console.ReadLine());
            bool[] tablica = new bool[liczba + 1];

            //Wypełnienie tablicy wartościami true
            for (int i = 1; i <= liczba; i++)
            {
                tablica[i] = true;
            }

            //Sito Erastotenesa
            for (int i = 2; i <= liczba; i++)
            {
                if (tablica[i])
                {
                    x = i;
                    x = x + i;
                    while (x <= liczba)
                    {
                        tablica[x] = false;
                        x = x + i;
                    }
                }
            }

            //Wyświetlenie liczb pierwszych z zakresu 1 - liczba
            for (int i = 1; i <= liczba; i++)
            {
                if (tablica[i])
                {
                    Console.Write(i + " , ");
                }

            Console.ReadKey();
        }
    }
}
