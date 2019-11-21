using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter Value of A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Value of B: ");
            b = Convert.ToInt16(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Value of A After Swap is "+ a + " And B After Sawp is " +b );

            Console.ReadKey();
        }
    }
}
