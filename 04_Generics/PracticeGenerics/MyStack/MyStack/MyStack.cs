using System;
using System.Collections.Generic;

namespace MyStackApp
{
    public class MyStack<T>
    {
        private List<T> _elements = new List<T>();

        // Returns the number of elements in the stack
        public int Count()
        {
            return _elements.Count;
        }

        // Adds an item to the top of the stack
        public void Push(T item)
        {
            _elements.Add(item);
        }

        // Removes and returns the item at the top of the stack
        public T Pop()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            T topItem = _elements[_elements.Count - 1];
            _elements.RemoveAt(_elements.Count - 1);
            return topItem;
        }
    }
}