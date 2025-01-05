using System;
using System.Collections.Generic;

namespace FindPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number: ");
            if (!int.TryParse(Console.ReadLine(), out int startNum))
            {
                Console.WriteLine("Invalid start number.");
                return;
            }

            Console.Write("Enter the end number: ");
            if (!int.TryParse(Console.ReadLine(), out int endNum))
            {
                Console.WriteLine("Invalid end number.");
                return;
            }

            if (startNum > endNum)
            {
                Console.WriteLine("Start number should be less than or equal to end number.");
                return;
            }

            int[] primes = FindPrimesInRange(startNum, endNum);
            Console.WriteLine($"Prime numbers between {startNum} and {endNum}: " + (primes.Length > 0 ? string.Join(", ", primes) : "None"));
        }

        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeList = new List<int>();

            for(int num = Math.Max(startNum, 2); num <= endNum; num++)
            {
                if(IsPrime(num))
                {
                    primeList.Add(num);
                }
            }

            return primeList.ToArray();
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for(int i = 3; i <= boundary; i += 2)
            {
                if(number % i == 0)
                    return false;
            }

            return true;
        }
    }
}