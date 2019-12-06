using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[3][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6 }
            };

            //Wyświetl zawartość tablicy za pomocą dwóch pętli for
            Console.WriteLine(tab.GetLength(0)); //3
            Console.WriteLine(tab.Length); //3

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                //Console.WriteLine(tab[i])
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0} ", tab[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
