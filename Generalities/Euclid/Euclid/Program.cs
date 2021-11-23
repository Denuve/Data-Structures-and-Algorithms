using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aCpy, bCpy;

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            aCpy = a;

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            bCpy = b;

            while (a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            Console.WriteLine("Cel mai mare divizor comun dintre {0} si {1} este {2}",aCpy,bCpy, a);

            Console.ReadKey();
            
        }
    }
}
