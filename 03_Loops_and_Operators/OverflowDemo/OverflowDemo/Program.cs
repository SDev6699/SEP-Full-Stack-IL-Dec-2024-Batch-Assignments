using System;

namespace OverflowDemo
{
    class Program
    {
        
        /*
         * Expected Behavior:
           Since byte ranges from 0 to 255, when i reaches 255 and increments, it overflows back to 0.
           This causes an infinite loop because i will always be less than 500 when it wraps around.
           Add Warning for Overflow: Modify the code to warn about the overflow without changing the original loop.
         */
        static void Main(string[] args)
        {
            int max = 500;
            try
            {
                checked
                {
                    for (byte i = 0; i < max; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow detected: 'byte' cannot exceed its maximum value of 255.");
            }
        }
    }
}