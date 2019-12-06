using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_wartościowe_i_referencyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Typ wartościowy
            int a = 10;
            int b = a;

            a--;
            b--;

            Console.WriteLine(a); //9
            Console.WriteLine(b); //11

            //Typ referencyjny
            int[] tabA = { 1, 2, 3 };
            int[] tabB = tabA;

            tabA[0] = 100;
            tabB[tabB.Length - 1] = 300; //Wyświetla ostatni element tablicy; w tym przypadku zostaje mu przypisana wartość 300

            Console.WriteLine("\ntabA");

            foreach (int item in tabA)
            {
                Console.Write("{0} ", item);
            }


            Console.WriteLine("\ntabB");

            foreach (int item in tabB)
            {
                Console.Write("{0} ", item);
            }

            //Kopiowanie tablic
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[7];

            Console.WriteLine("\ntabCopy");

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

            tab.CopyTo(tabCopy, 0);

            Array.Copy(tab, tabCopy, tab.Length);

            foreach (int item in tabCopy)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}