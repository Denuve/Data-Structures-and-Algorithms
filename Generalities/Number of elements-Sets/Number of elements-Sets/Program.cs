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

            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            b = int.Parse(Console.ReadLine());

            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            Console.Write("d=");
            d = int.Parse(Console.ReadLine());

            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            if (a == b && a == c && a == d && a == e)
            {
                Console.WriteLine("Toate valorile sunt egale");
            }

            //a,b,c,d,e
            else if ((a == b && a == c && a == d) || (a == c && a == d & a == e) ||
                    (a == b && a == c && a == e) || (a == b && a == d && a == e) ||
                    (b == c && b == d && b == e))
            {
                Console.WriteLine("Exista 4 valori egale");
            }

            else if ((a == b && a == c && d == e) || (a == b && a == d && c == e) ||
                    (a == b && a == e && c == d) || (a == c && a == d && b == e) ||
                    (a == c && a == e && b == d) || (a == d && a == e && b == c) ||
                    (b == c && b == d && a == e) || (b == c && b == e && a == d) || (b == d && b == e && a == c) ||
                    (c == d && c == e && a == b))
            {
                Console.WriteLine("Exista 3 valori egale iar celelalte 2 sunt de asemenea egale");
            }

            //a,b,c,d,e
            else if ((a == b && a == c) || (a == b && a == d) || (a == b && a == e) ||
                    (a == c && a == d) || (a == c && a == e) || (a == d && a == e) ||
                    (b == c && b == d) || (b == c && b == e) || (b == d && b == e) ||
                    (c == d && c == e))
            {
                Console.WriteLine("Exista 3 numere egale");
            }

            else if ((a == b && c == d) || (a == c && d == e)||  (b == c && d == e))
            {
                //Not finished
                Console.WriteLine("Exista 2 cate 2 valori identice");
            }


            else if (a == b || a == c || a == d || a == e || b == c || b == d || b == e || c == d || c == e || d == e)
            {
                Console.WriteLine("Exista 2 valori identice");
            }

            
            

            

           
            Console.ReadKey();
        }
    }
}
