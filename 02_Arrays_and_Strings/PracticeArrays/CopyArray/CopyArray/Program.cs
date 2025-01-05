using System;

namespace CopyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the original array with 10 integers
            int[] originalArray = new int[10];
            for(int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = i + 1; // Assign values 1 to 10
            }

            // Create a new array with the same length as the original
            int[] copiedArray = new int[originalArray.Length];

            // Copy elements from original to copied array using a loop
            for(int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }

            // Print both arrays to verify the copy
            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Copied Array:   " + string.Join(", ", copiedArray));
        }
    }
}