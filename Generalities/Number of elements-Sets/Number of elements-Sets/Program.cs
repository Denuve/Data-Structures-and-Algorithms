using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_elements_Sets
{
    class Program
    {
        /*
         *  Implementarea problemelor ce ţin de numărul de elemente 
            identice într-o mulţime (1,3,4,1,1) = 3 bucăţi
            [Se dau 5 valori întregi a,b,c,d şi e. Construiţi un algoritm
            care identifică următoarele cazuri: 
            1.) Există 2 valori
            identice, 
            2.) Există 2 cȃte 2 valori identice, 
            3.) Există 3 valori identice, 
            4.) Există 3 valori identice şi celelalte 2
            sunt de asemena identice, 
            5.) Există 4 valori identice 
            6.)Toate valorile sunt identice 

            7.)Să se verifice dacă valorile
            pot fi elementele consecutive ale unei progresii aritmetice
            cu raţia 1.
        */
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            int j = 0;

            int[] x = new int[100];
            int[] y = new int[4];

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            x[a]++;

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            x[b]++;

            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            x[c]++;

            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            x[d]++;

            Console.Write("e=");
            e = int.Parse(Console.ReadLine());
            x[e]++;

            for (int i = 0; i < x.Length; i++)
            {
                if( x[i] != 0 )
                {
                    y[j] = x[i];
                    j++;
                }
            }

            Console.ReadKey();
        }
    }
}
