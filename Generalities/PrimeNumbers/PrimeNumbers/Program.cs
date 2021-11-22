using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;

            Random rnd = new Random();
            n = rnd.Next();

            if (Prime(n))
            {
                Console.WriteLine("Numarul {0} este PRIM!", n);
            }
            else
            {
                Console.WriteLine("Numarul {0} NU este prim!", n);

            }
            Console.ReadKey();
            
        }

        private static bool Prime(int n)
        {
            if( n == 1)
            {
                return false;
            }

            if( n == 2)
            {
                return true;
            }
            if( n % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i * i < n / 2; i+=2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
