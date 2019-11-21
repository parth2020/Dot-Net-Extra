using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int km, m, cm;
            double inch, feet;
            Console.WriteLine("Enter Kilometers: ");
            km = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("1. Kilometers to M:  ");
            Console.WriteLine("2. Kilometers to CM:  ");
            Console.WriteLine("3. Km to Feet: ");
            Console.WriteLine("4. Km to Inches: ");
            Console.Write("Enter Choice(1-4):");
            int ch = Int32.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    m = km * 1000;
                    Console.WriteLine("Meters" + m);
                    break;

                case 2:
                    cm = km * 100000;
                    Console.WriteLine("CentiMeters" + cm);
                    break;

                case 3:
                    feet = km * 3280.83;
                    Console.WriteLine("Feet" + feet);
                    break;

                case 4:
                    inch = km * 39370.1;
                    Console.WriteLine("Inches" + inch);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}