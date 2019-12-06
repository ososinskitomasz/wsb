using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA05_POT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dla danych dwóch liczb naturalnych a i b, wyznaczyć ostatnią cyfrę liczby a^b.
            /*Console.WriteLine("Ile razy wykonać obliczenie a^b oraz wyświetlić jego wynik i ostatnią jego cyfrę: ");
            int p = Console.Read();

            if (p <= 1 && p <= 10)*/
            {
                Console.Write("Podaj a: ");
                string a = Console.ReadLine();

                uint czyUint;
                if (uint.TryParse(a, out czyUint) == true)
                {
                    Console.Write("Podaj b: ");
                    string b = Console.ReadLine();
                    if (uint.TryParse(b, out czyUint) == true)
                    {
                        if (double.Parse(b) > 1)
                        {
                            double wynik = double.Parse(a);
                            for (double z = double.Parse(b); z > 1; z--)
                            {
                                wynik *= double.Parse(a);
                            }

                            Console.WriteLine("Wynik: " + wynik);

                            double ostatniaCyfra = wynik % 10;
                            Console.WriteLine("Ostatnia cyfra wyniku: " + ostatniaCyfra);

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Wynik: " + a);
                            Console.WriteLine("Ostatnia cyfra wyniku: " + a);

                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("To nie jest prawidłowa liczba!");

                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("To nie jest prawidłowa liczba!");

                    Console.ReadKey();
                }
            }
        }
    }
}
