using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array elements (space separated): ");
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.Write("Enter the number of rotations (k): ");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("Invalid number of rotations.");
                return;
            }

            int n = array.Length;
            int[] sum = new int[n];

            for(int r = 1; r <= k; r++)
            {
                array = RotateRight(array, 1);
                Console.WriteLine($"rotated{r}[] = " + string.Join(" ", array));

                for(int i = 0; i < n; i++)
                {
                    sum[i] += array[i];
                }
            }

            Console.WriteLine("sum[] = " + string.Join(" ", sum));
        }

        static int[] RotateRight(int[] arr, int times)
        {
            int n = arr.Length;
            int[] rotated = new int[n];
            for(int i = 0; i < n; i++)
            {
                rotated[(i + times) % n] = arr[i];
            }
            return rotated;
        }
    }
}