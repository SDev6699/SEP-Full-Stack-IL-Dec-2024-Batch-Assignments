using System;

namespace PrintAPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 5;

            for (int i = 1; i <= numberOfRows; i++)
            {
                // Print spaces
                for (int j = 1; j <= numberOfRows - i; j++)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Move to next line
                Console.WriteLine();
            }
        }
    }
}