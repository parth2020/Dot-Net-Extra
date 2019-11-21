using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, f, i, j, cnt;
            Console.WriteLine("Input the Starting Range:");
            s = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input the Ending Range:");
            f = Convert.ToInt16(Console.ReadLine());

            Console.Write("The prime numbers between {0} and {1} are : \n",s,f);

            for (i = s; i <= f; i++)
            {
                cnt = 0;
                for(j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        cnt = cnt +1;
                        break;
                    }

                }
                if(cnt==0 && i!= 1)
                       Console.Write("{0} ",i);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
