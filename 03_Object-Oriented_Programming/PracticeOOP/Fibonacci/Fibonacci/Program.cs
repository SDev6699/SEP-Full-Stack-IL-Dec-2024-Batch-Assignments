using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 numbers of the Fibonacci sequence:");
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(FibonacciMethod(i) + (i < 10 ? ", " : "\n"));
            }
        }

        // Recursive method to calculate the nth Fibonacci number
        static int FibonacciMethod(int n)
        {
            if(n <= 0)
                throw new ArgumentException("n must be a positive integer.");
            if(n == 1 || n == 2)
                return 1;
            return FibonacciMethod(n - 1) + FibonacciMethod(n - 2);
        }
    }
}