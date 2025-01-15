using System;

namespace ColorBall
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create Color instances
                Color redColor = new Color(255, 0, 0);
                Color blueColor = new Color(0, 0, 255, 128); // Semi-transparent

                // Create Ball instances
                Ball ball1 = new Ball(5.0, redColor);
                Ball ball2 = new Ball(3.5, blueColor);

                // Throw ball1 three times
                ball1.Throw();
                ball1.Throw();
                ball1.Throw();

                // Throw ball2 twice
                ball2.Throw();
                ball2.Throw();

                // Pop ball1
                ball1.Pop();

                // Attempt to throw ball1 again
                ball1.Throw(); // Should not increment throw count

                // Print throw counts
                Console.WriteLine($"Ball1 has been thrown {ball1.GetThrowCount()} times."); // Expected: 3
                Console.WriteLine($"Ball2 has been thrown {ball2.GetThrowCount()} times."); // Expected: 2
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}