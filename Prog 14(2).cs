using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("Enter The Number of Rows");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = n; i >= 1; --i)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

