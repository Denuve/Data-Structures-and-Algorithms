using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(0, 100);
            }

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[j] < x[i])
                    {
                        int aux = x[j];
                        x[j] = x[i];
                        x[i] = aux;
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
