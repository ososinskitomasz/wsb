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
            Console.Write("Name: "); //elooo
            Console.WriteLine("Tomasz");
            /*xddd
             * omg
             */

            string name = "Tomasz";
            string name1 = "Anna";
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your name is: {0}", name);

            int age = 25;
            sbyte age1 = 20;

            Console.WriteLine("His name = {0}, age = {1}", name, age);
            Console.WriteLine("Her name = {0}, age = {1}", name, age1);


            Console.ReadKey();
        }
    }
}
