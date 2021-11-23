using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {   /*Se citesc de la tastaură o serie de numere pȃnă cȃnd se
        introduce o valoare dată (-1). Să se afişeze minimul
        valorilor citite, şi eventual numărul de apariţie a acestei
        valori        */

        //Not finished
        static void Main(string[] args)
        {
            int x = 100;
            int[] values = new int[100];

            while(x != -1)
            {
                Console.WriteLine("x=");
                x = int.Parse(Console.ReadLine());
                values[x]++;
            }

            Console.ReadKey();
 
        }
    }
}
