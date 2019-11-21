using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra13
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 1, Ans, i, number;
            Console.WriteLine("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(m + " " + n + " ");
            for (i = 2; i < number; ++i)
            {
                Ans = m + n;
                Console.WriteLine(Ans + "");
                m = n;
                n = Ans;

            }

            Console.ReadKey();
        }
    }
}