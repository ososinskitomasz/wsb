using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(4, 6);
            Add(1, 2, 3);
            Console.WriteLine(SquareArea(5));
            Console.WriteLine(Add(1, 2, 3, 4));
            Data("Janusz");
            Data("Tomasz", "Oso", 25);
            Nazwy(name: "Kuba", vendor: "Tomek", screen: 2);
            Nazwy("Jakub", "Tomek", screen: 2);
            Nazwy(screen: 2, name: "Dupa", vendor: "Chuj");

            Console.ReadKey();
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: {0}", result);
        }

        static void Add(int a, int b, int c)
        {
            Console.WriteLine("Wynik dodawania: {0}", a + b + c);
        }

        static int SquareArea(int a)
        {
            return a * a;
        }

        static int Add(int a, int b, int c = 2, int d = 1)
        {
            return a + b + c + d;
        }

        static void Data(string name, string surname = "Nowak", int age = 20)
        {
            Console.WriteLine("Imię: {0}, nazwisko: {1}, wiek: {2}", name, surname, age);
        }

        static void Nazwy(string name, string vendor, string color = "Niebieski", int screen = 12)
        {
            Console.WriteLine("Model: {0}, producent: {1}, kolor: {2}, rozmiar matrycy: {3}", name, vendor, color, screen);
        }
    }
}
