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
            int i, j, n, k = 0;
            Console.WriteLine("Enter The Number of Rows");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(k);
                }
                if (k == 0)
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}