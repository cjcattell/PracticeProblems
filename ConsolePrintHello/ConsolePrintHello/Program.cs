using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrintHello
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your name?");
            System.Console.WriteLine("My name is: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Hello, " + name);
            System.Console.ReadKey();

        }
    }
}
