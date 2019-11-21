using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, bin, dec = 0, b = 1, rem, c, i;
            int[] a = new int[10];

            Console.WriteLine("1.binary----> decimal");
            Console.WriteLine("2.decimal----> binary");
            Console.WriteLine("enetr your choice");
            c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.Write("Enter a Binary number : ");
                    n = int.Parse(Console.ReadLine());
                    bin = n;
                    while (n > 0)
                    {
                        rem = n % 10;
                        dec = dec + rem * b;
                        n = n / 10;
                        b = b * 2;
                    }

                    Console.WriteLine("converted decimal is  : " + dec);
                    Console.ReadLine();
                    break;
                case 2:

                    Console.Write("Enter the decial number : ");
                    n = int.Parse(Console.ReadLine());
                    for (i = 0; n > 0; i++)
                    {
                        a[i] = n % 2;
                        n = n / 2;
                    }
                    Console.WriteLine("Binary of the given number :");
                    for (i = i - 1; i >= 0; i--)
                    {
                        Console.Write(a[i]);
                    }
                    Console.WriteLine(" ");
                    break;

            }
        }
    }
}