using System;

namespace MyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of strings
            MyList<string> fruits = new MyList<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.DisplayAll();

            Console.WriteLine();

            // Checking if list contains "Banana"
            Console.WriteLine($"Contains 'Banana': {fruits.Contains("Banana")}"); // Output: True

            // Removing element at index 1
            string removedFruit = fruits.Remove(1);
            Console.WriteLine($"Removed: {removedFruit}");
            fruits.DisplayAll();

            Console.WriteLine();

            // Inserting "Blueberry" at index 1
            fruits.InsertAt("Blueberry", 1);
            fruits.DisplayAll();

            Console.WriteLine();

            // Deleting element at index 2
            fruits.DeleteAt(2);
            fruits.DisplayAll();

            Console.WriteLine();

            // Finding element at index 0
            string firstFruit = fruits.Find(0);
            Console.WriteLine($"Element at index 0: {firstFruit}");

            Console.WriteLine();

            // Clearing the list
            fruits.Clear();
            fruits.DisplayAll(); // Should display nothing
        }
    }
}