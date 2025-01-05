using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to reverse its words:");
            string input = Console.ReadLine();

            string reversedSentence = ReverseWordsInSentence(input);
            Console.WriteLine("Reversed Sentence:");
            Console.WriteLine(reversedSentence);
        }

        static string ReverseWordsInSentence(string sentence)
        {
            // Define separators
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            // Split the sentence keeping the separators
            string pattern = @"([.,:;=()\&\[\]\""'\\\/!? ])";
            string[] tokens = Regex.Split(sentence, pattern);

            // Extract words and store their positions
            List<string> words = new List<string>();
            List<int> wordPositions = new List<int>();

            for(int i = 0; i < tokens.Length; i++)
            {
                if(!string.IsNullOrEmpty(tokens[i]) && !IsSeparator(tokens[i], separators))
                {
                    words.Add(tokens[i]);
                    wordPositions.Add(i);
                }
            }

            // Reverse the list of words
            words.Reverse();

            // Replace the words in the tokens array with reversed words
            for(int i = 0; i < wordPositions.Count; i++)
            {
                tokens[wordPositions[i]] = words[i];
            }

            // Reconstruct the sentence
            return string.Join("", tokens);
        }

        static bool IsSeparator(string token, char[] separators)
        {
            foreach(char sep in separators)
            {
                if(token.Contains(sep))
                    return true;
            }
            return false;
        }
    }
}
