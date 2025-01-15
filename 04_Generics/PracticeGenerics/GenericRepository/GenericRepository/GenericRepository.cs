using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepositoryApp
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _dataStore = new List<T>();

        public void Add(T item)
        {
            if(item == null)
                throw new ArgumentNullException(nameof(item));

            // Assign a unique Id if not set
            if(item.Id == 0)
            {
                item.Id = _dataStore.Count > 0 ? _dataStore.Max(e => e.Id) + 1 : 1;
            }

            _dataStore.Add(item);
        }

        public void Remove(T item)
        {
            if(item == null)
                throw new ArgumentNullException(nameof(item));

            _dataStore.Remove(item);
        }

        public void Save()
        {
            // In a real implementation, this would persist changes to the data source.
            // For in-memory, no action is needed.
            Console.WriteLine("Changes saved to the repository.");
        }

        public IEnumerable<T> GetAll()
        {
            return _dataStore;
        }

        public T GetById(int id)
        {
            return _dataStore.FirstOrDefault(e => e.Id == id);
        }
    }
}