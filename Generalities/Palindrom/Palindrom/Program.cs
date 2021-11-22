using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, CopyN,c , reversed = 0;

            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            CopyN = n;

            while (n != 0)
            {
                c = n % 10;
                reversed = reversed * 10 + c;
                n = n / 10;
            }

            if (reversed == CopyN)
            {
                Console.WriteLine("Numarul {0} este palindrom!", CopyN);
            }
            else
            {
                Console.WriteLine("Numarul {0} NU este palindrom!", CopyN);

            }

            Console.ReadKey();

            
        }
    }
}
