using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text to extract palindromes:");
            string input = Console.ReadLine();

            List<string> palindromes = ExtractUniquePalindromes(input);

            if(palindromes.Count > 0)
            {
                Console.WriteLine("Palindromes: " + string.Join(", ", palindromes));
            }
            else
            {
                Console.WriteLine("No palindromes found.");
            }
        }

        static List<string> ExtractUniquePalindromes(string text)
        {
            // Use regex to extract words (alphanumeric characters)
            string pattern = @"\b\w+\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            HashSet<string> palindromeSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach(Match match in matches)
            {
                string word = match.Value;
                if(word.Length > 1 && IsPalindrome(word))
                {
                    // To ensure uniqueness regardless of case
                    palindromeSet.Add(word.ToLower());
                }
            }

            // Convert back to original case (assuming first occurrence)
            List<string> uniquePalindromes = matches
                .Cast<Match>()
                .Select(m => m.Value)
                .Where(w => w.Length > 1 && IsPalindrome(w))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(w => w.ToLower())
                .ToList();

            return uniquePalindromes;
        }

        static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while(left < right)
            {
                if(char.ToLower(word[left]) != char.ToLower(word[right]))
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
