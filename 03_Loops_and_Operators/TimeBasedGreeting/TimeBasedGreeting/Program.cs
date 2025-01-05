using System;

namespace TimeBasedGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // For testing, you can define a specific DateTime
            // DateTime currentTime = new DateTime(2025, 1, 5, 14, 30, 0); // Example: 2:30 PM
            DateTime currentTime = DateTime.Now;

            int hour = currentTime.Hour;

            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (hour >= 17 && hour < 21)
            {
                Console.WriteLine("Good Evening");
            }

            if (hour >= 21 || hour < 5)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}