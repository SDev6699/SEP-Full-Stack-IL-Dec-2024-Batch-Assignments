using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            // Method 1: Using Char Array
            string reversedUsingCharArray = ReverseUsingCharArray(input);
            Console.WriteLine("Reversed using Char Array: " + reversedUsingCharArray);

            // Method 2: Using For-Loop
            string reversedUsingForLoop = ReverseUsingForLoop(input);
            Console.WriteLine("Reversed using For-Loop: " + reversedUsingForLoop);
        }

        static string ReverseUsingCharArray(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ReverseUsingForLoop(string str)
        {
            string reversed = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }
    }
}