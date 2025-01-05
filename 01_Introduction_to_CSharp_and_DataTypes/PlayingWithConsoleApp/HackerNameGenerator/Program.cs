using System;

namespace HackerNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hacker Name Generator!");

            Console.Write("Enter your favorite color: ");
            string color = Console.ReadLine();

            Console.Write("Enter your astrology sign: ");
            string sign = Console.ReadLine();

            Console.Write("Enter your street address number: ");
            string addressNumber = Console.ReadLine();

            string hackerName = $"{color}{sign}{addressNumber}";
            Console.WriteLine($"Your hacker name is {hackerName}.");
        }
    }
}