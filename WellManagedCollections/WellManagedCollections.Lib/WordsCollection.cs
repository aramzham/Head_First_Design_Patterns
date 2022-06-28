using System.Collections;
using System.Collections.Generic;

namespace WellManagedCollections.Lib
{
    public class WordsCollection : IEnumerable
    {
        private readonly List<string> _collection = new List<string>();

        private bool _direction = false;
        
        public void ReverseDirection() => _direction = !_direction;
        
        public List<string> GetItems() => _collection;
        
        public void AddItem(string item) => _collection.Add(item);
        
        public IEnumerator GetEnumerator() => new AlphabeticalOrderIterator(this, _direction);
    }
}