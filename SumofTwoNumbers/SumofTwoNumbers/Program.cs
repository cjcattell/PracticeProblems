//Collect two input numbers and calculate and print the sum..

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("First number: ");
            string i1 = Console.ReadLine();

            System.Console.WriteLine("Second number: ");
            string i2 = Console.ReadLine();

            int n1, n2;
            Int32.TryParse(i1, out n1);
            Int32.TryParse(i2, out n2);
            int sum = n1 + n2;

            System.Console.WriteLine(n1 + " + " + n2 + " = " + sum);
            Console.ReadKey();
            
        }
    }
}
