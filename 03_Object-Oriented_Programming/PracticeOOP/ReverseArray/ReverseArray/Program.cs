using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            Reverse(numbers);
            Console.WriteLine("Reversed Array: " + string.Join(", ", numbers));

            PrintNumbers(numbers);
        }

        // Method to generate an array of n integers
        static int[] GenerateNumbers(int n)
        {
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = i + 1; // Assign values 1 to n
            }
            return array;
        }

        // Method to reverse the array in place
        static void Reverse(int[] array)
        {
            int temp;
            for(int i = 0; i < array.Length / 2; i++)
            {
                int j = array.Length - i - 1;
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        // Method to print the array
        static void PrintNumbers(int[] array)
        {
            Console.WriteLine("Final Array: " + string.Join(", ", array));
        }
    }
}