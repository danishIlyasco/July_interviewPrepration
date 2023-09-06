using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibnocciSeriesRecurrsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fib(10));
            Console.ReadKey();
        }

        static int fib(int n)
        {

            if (n <= 2)
            {
                return 1;
            }

            return fib(n - 1) + fib(n - 2);
        }
    }
}
