using System;
using System.Collections.Generic;

namespace ManageList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            Console.WriteLine("Welcome to the List Manager!");

            while (true)
            {
                Console.WriteLine("\nCurrent List: " + (items.Count > 0 ? string.Join(", ", items) : "Empty"));
                Console.Write("Enter command (+ item, - item, or -- to clear, or exit to quit): ");
                string input = Console.ReadLine().Trim();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting the List Manager. Goodbye!");
                    break;
                }
                else if (input.StartsWith("+"))
                {
                    string itemToAdd = input.Substring(1).Trim();
                    if (!string.IsNullOrEmpty(itemToAdd))
                    {
                        items.Add(itemToAdd);
                        Console.WriteLine($"Added: {itemToAdd}");
                    }
                    else
                    {
                        Console.WriteLine("No item specified to add.");
                    }
                }
                else if (input.StartsWith("-"))
                {
                    string itemToRemove = input.Substring(1).Trim();
                    if (items.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {itemToRemove}");
                    }
                }
                else if (input == "--")
                {
                    items.Clear();
                    Console.WriteLine("List cleared.");
                }
                else
                {
                    Console.WriteLine("Invalid command. Please use + item, - item, -- to clear, or exit.");
                }
            }
        }
    }
}
