using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your sallary to generate pay slip:");
            int a = Convert.ToInt32(Console.ReadLine());
            float da = ((10) * (a)) / (100);
            double hra = ((7.5) * (a)) / (100);
            int ma = 300;
            double pf = ((12.5) * (a)) / (100);
            float gross = Convert.ToInt32(a + da + hra + ma + pf);
            Console.WriteLine("Your sallary slip \nBasic:" + a + "\tD.A.:" + da + "\nH.R.A.:" + hra + "\tM.A.:" + ma + "\nP.F.:" + pf + "\nGross Sallary is :" + gross);
        }
    }
}