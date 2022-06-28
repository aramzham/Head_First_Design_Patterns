using System.Collections;

namespace WellManagedCollections.Lib
{
    public class AlphabeticalOrderIterator : IEnumerator
    {
        private readonly WordsCollection _collection;
        
        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;
        
        private readonly bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse)
            {
                _position = collection.GetItems().Count;
            }
        }
        
        public bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }

        object IEnumerator.Current => _collection.GetItems()[_position];
    }
}