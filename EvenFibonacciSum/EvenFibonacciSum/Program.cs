using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long fib1 = 2;
            long fib2 = 0;
            long result = 2;
            long sum = 0;

            while (result <= 4000000)
            {
                sum += result;

                result = 4 * fib1 + fib2;
                fib2 = fib1;
                fib1 = result;
            }

            Console.WriteLine("The sum of the even Fibonacci sequence numbers less than 4 million: {0}", sum);

            Console.Read();
        }
    }
}
