using System;
using System.Collections.Generic;

namespace MyListApp
{
    public class MyList<T>
    {
        private List<T> _elements = new List<T>();

        // Adds an element to the list
        public void Add(T element)
        {
            _elements.Add(element);
        }

        // Removes the element at the specified index and returns it
        public T Remove(int index)
        {
            if(index < 0 || index >= _elements.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            T removedElement = _elements[index];
            _elements.RemoveAt(index);
            return removedElement;
        }

        // Checks if the list contains the specified element
        public bool Contains(T element)
        {
            return _elements.Contains(element);
        }

        // Clears all elements from the list
        public void Clear()
        {
            _elements.Clear();
        }

        // Inserts an element at the specified index
        public void InsertAt(T element, int index)
        {
            if(index < 0 || index > _elements.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            _elements.Insert(index, element);
        }

        // Deletes the element at the specified index
        public void DeleteAt(int index)
        {
            if(index < 0 || index >= _elements.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            _elements.RemoveAt(index);
        }

        // Finds and returns the element at the specified index
        public T Find(int index)
        {
            if(index < 0 || index >= _elements.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            return _elements[index];
        }

        // Method to display all elements (for demonstration purposes)
        public void DisplayAll()
        {
            Console.WriteLine("List Contents:");
            for(int i = 0; i < _elements.Count; i++)
            {
                Console.WriteLine($"Index {i}: {_elements[i]}");
            }
        }
    }
}
