using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(-100, 100);
            }

            for (int i = 1; i < x.Length - 1; i++)
            {
                if (x[i] <= 0)
                {
                    while (true)
                    {

                    }
                }           
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("{0} ", x[i]);
            }

            Console.ReadKey();
        }
    }
}
