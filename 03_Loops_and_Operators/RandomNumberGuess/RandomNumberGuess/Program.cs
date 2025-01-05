using System;

namespace RandomNumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 4); // Generates 1, 2, or 3

            Console.Write("Guess the number (1-3): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guessedNumber))
            {
                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Your guess is out of the valid range (1-3).");
                }
                else if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 3.");
            }
        }
    }
}