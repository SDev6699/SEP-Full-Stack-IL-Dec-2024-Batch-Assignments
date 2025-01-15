using System;

namespace MyStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack of integers
            MyStack<int> intStack = new MyStack<int>();
            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            Console.WriteLine($"Stack Count: {intStack.Count()}"); // Output: 3

            Console.WriteLine($"Popped: {intStack.Pop()}"); // Output: 30
            Console.WriteLine($"Stack Count after Pop: {intStack.Count()}"); // Output: 2

            // Create a stack of strings
            MyStack<string> stringStack = new MyStack<string>();
            stringStack.Push("Apple");
            stringStack.Push("Banana");
            stringStack.Push("Cherry");

            Console.WriteLine($"Stack Count: {stringStack.Count()}"); // Output: 3

            Console.WriteLine($"Popped: {stringStack.Pop()}"); // Output: Cherry
            Console.WriteLine($"Stack Count after Pop: {stringStack.Count()}"); // Output: 2
        }
    }
}