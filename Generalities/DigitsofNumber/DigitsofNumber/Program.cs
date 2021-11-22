using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsofNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = rnd.Next();
            Console.WriteLine(n);
            int c;
            int reversed = 0;
       
            while (n != 0)
            {
                c = n % 10;
                reversed = reversed * 10 + c;
                n = n / 10;
            }

            while (reversed != 0)
            {
                c = reversed % 10;
                Console.WriteLine("{0} ", c);
                reversed = reversed / 10;
            }

            Console.ReadKey();
            
        }
    }
}
