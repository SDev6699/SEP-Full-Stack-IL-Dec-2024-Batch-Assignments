using System;
using System.Collections.Generic;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers (space separated):");
            string input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[tokens.Length];
            for(int i = 0; i < tokens.Length; i++)
            {
                if(!int.TryParse(tokens[i], out numbers[i]))
                {
                    Console.WriteLine($"Invalid number: {tokens[i]}");
                    return;
                }
            }

            // Find the frequency of each number
            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
            foreach(int num in numbers)
            {
                if(frequencyDict.ContainsKey(num))
                {
                    frequencyDict[num]++;
                }
                else
                {
                    frequencyDict[num] = 1;
                }
            }

            // Find the maximal frequency
            int maxFrequency = 0;
            foreach(var kvp in frequencyDict)
            {
                if(kvp.Value > maxFrequency)
                    maxFrequency = kvp.Value;
            }

            // Find all numbers with the maximal frequency
            List<int> mostFrequentNumbers = new List<int>();
            foreach(var kvp in frequencyDict)
            {
                if(kvp.Value == maxFrequency)
                    mostFrequentNumbers.Add(kvp.Key);
            }

            if(mostFrequentNumbers.Count == 1)
            {
                Console.WriteLine($"The number {mostFrequentNumbers[0]} is the most frequent (occurs {maxFrequency} times)");
            }
            else
            {
                // Find the leftmost number among the most frequent numbers
                int leftmost = -1;
                int firstIndex = numbers.Length;
                foreach(int num in mostFrequentNumbers)
                {
                    int index = Array.IndexOf(numbers, num);
                    if(index < firstIndex)
                    {
                        firstIndex = index;
                        leftmost = num;
                    }
                }

                // Prepare the list of numbers with maximal frequency
                string numbersList = string.Join(", ", mostFrequentNumbers);
                Console.WriteLine($"The numbers {numbersList} have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {leftmost}.");
            }
        }
    }
}
