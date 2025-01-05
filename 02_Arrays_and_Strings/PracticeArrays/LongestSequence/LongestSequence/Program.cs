using System;
using System.Collections.Generic;

namespace LongestSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array elements (space separated): ");
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

            List<int> longestSeq = FindLongestSequence(array);

            if(longestSeq.Count > 0)
            {
                Console.WriteLine("Longest sequence: " + string.Join(" ", longestSeq));
            }
            else
            {
                Console.WriteLine("No elements found.");
            }
        }

        static List<int> FindLongestSequence(int[] array)
        {
            if(array.Length == 0)
                return new List<int>();

            List<int> currentSeq = new List<int> { array[0] };
            List<int> longestSeq = new List<int> { array[0] };

            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] == array[i - 1])
                {
                    currentSeq.Add(array[i]);
                }
                else
                {
                    if(currentSeq.Count > longestSeq.Count)
                    {
                        longestSeq = new List<int>(currentSeq);
                    }
                    currentSeq.Clear();
                    currentSeq.Add(array[i]);
                }
            }

            // Check at the end
            if(currentSeq.Count > longestSeq.Count)
            {
                longestSeq = new List<int>(currentSeq);
            }

            return longestSeq;
        }
    }
}