using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Prod_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Algoritmul de calcul a sumei/produsului/normei elementelor unui vector
               Algoritmul de calcul a minimului/maximului elementelor unui vector
            */

            int[] x = new int[50];
            int sum = 0 , min = int.MaxValue, max = int.MinValue;
            double norm, prod = 1;

            Random rnd = new Random();

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 100);
                sum += x[i];
                prod *= x[i];

                if(x[i] > max)
                {
                    max = x[i];
                }

                if(x[i] < min)
                {
                    min = x[i];
                }
                Console.Write("{0} ", x[i]);
            }
            
            norm = Math.Sqrt(sum);

            Console.WriteLine("\nSum:{0}\nProd:{1}\nNorm:{2}\nMin:{3}\nMax:{4}", sum, prod, norm, min, max);

            Console.ReadKey();
            
        }
    }
}
