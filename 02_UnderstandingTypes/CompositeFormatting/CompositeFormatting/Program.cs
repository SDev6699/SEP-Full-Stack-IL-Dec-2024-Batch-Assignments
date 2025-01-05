using System;
using System.Numerics;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of centuries: ");
            if (int.TryParse(Console.ReadLine(), out int centuries))
            {
                // Start with decimal calculations for precise handling of fractional years
                decimal yearsPerCentury = 100m;
                decimal daysPerYear = 365.2425m;  // Gregorian calendar average
                
                // Calculate total days as decimal first
                decimal totalYears = centuries * yearsPerCentury;
                decimal totalDaysDecimal = totalYears * daysPerYear;
                
                // Convert to BigInteger after decimal calculations are complete
                BigInteger days = BigInteger.Parse(Math.Round(totalDaysDecimal).ToString());
                BigInteger years = BigInteger.Parse(Math.Round(totalYears).ToString());

                // Time conversion constants
                const int hoursPerDay = 24;
                const int minutesPerHour = 60;
                const int secondsPerMinute = 60;
                const int millisecondsPerSecond = 1000;
                const int microsecondsPerMillisecond = 1000;
                const int nanosecondsPerMicrosecond = 1000;

                // Calculate all time units using BigInteger arithmetic
                BigInteger hours = days * hoursPerDay;
                BigInteger minutes = hours * minutesPerHour;
                BigInteger seconds = minutes * secondsPerMinute;
                BigInteger milliseconds = seconds * millisecondsPerSecond;
                BigInteger microseconds = milliseconds * microsecondsPerMillisecond;
                BigInteger nanoseconds = microseconds * nanosecondsPerMicrosecond;

                // Format output using string interpolation with thousand separators
                Console.WriteLine($"{centuries} centuries = " +
                                $"{years:N0} years = " +
                                $"{days:N0} days = " +
                                $"{hours:N0} hours = " +
                                $"{minutes:N0} minutes = " +
                                $"{seconds:N0} seconds = " +
                                $"{milliseconds:N0} milliseconds = " +
                                $"{microseconds:N0} microseconds = " +
                                $"{nanoseconds:N0} nanoseconds");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number of centuries.");
            }
        }
    }
}