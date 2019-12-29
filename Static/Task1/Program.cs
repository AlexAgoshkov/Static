using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Plus(5, 5));
            Console.WriteLine(Calculator.Minus(5, 5));
            Console.WriteLine(Calculator.Division(5, 5));
            Console.WriteLine(Calculator.Multiply(5, 5));

            Console.ReadKey();
        }
    }
}
