using System;

namespace CountingIncrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 24;

            for (int increment = 1; increment <= 4; increment++)
            {
                for (int i = 0; i <= max; i += increment)
                {
                    if (i != 0)
                        Console.Write(",");
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}