using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three numbers");
            int a, b, c, temp;
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            c = Convert.ToInt16(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("a is greter");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is greter");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c is greter");
            }
        }
    }
}