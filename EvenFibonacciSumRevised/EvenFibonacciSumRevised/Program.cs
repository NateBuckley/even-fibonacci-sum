using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenFibonacciSumRevised
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] fib = {2, 0};
            int counter = 0;
            long sum = 0;

            while (fib[counter] <= 4000000)
            {
                sum += fib[counter];
                counter = (counter + 1) % 2;
                fib[counter] = 4 * fib[(counter + 1) % 2] + fib[counter];
            }

            Console.WriteLine("The sum of all even numbers of the Fibonacci sequence less than 4 million: {0}", sum);

            Console.Read();
        }
    }
}
