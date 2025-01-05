using System;

namespace BirthDateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth date (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                // Ensure birth date is not in the future
                if (birthDate > DateTime.Today)
                {
                    Console.WriteLine("Birth date cannot be in the future. Please enter a valid date.");
                    return;
                }

                DateTime today = DateTime.Today; // Use Today to avoid fractional day issues
                TimeSpan age = today - birthDate;
                int daysOld = (int)age.TotalDays;

                Console.WriteLine($"You are {daysOld} days old.");

                int daysToNextAnniversary = 10000 - (daysOld % 10000);
                DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);

                Console.WriteLine($"Your next 10,000-day anniversary is on {nextAnniversary:yyyy-MM-dd}.");
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
            }
        }
    }
}