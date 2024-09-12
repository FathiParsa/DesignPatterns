using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternSample
{
    public class WordIterator : IEnumerator
    {
        private WordCollection _collection;
        private int _currentIndex = -1;
        public WordIterator(WordCollection collection)
        {
            _collection = collection;
        }
        public object Current
        {
            get
            {
                if (_currentIndex >= 0 && _currentIndex < _collection.Count)
                {
                    return _collection[_currentIndex];
                }
                throw new InvalidOperationException();
            }
        }

        public bool MoveNext()
        {
            if (_currentIndex < _collection.Count -1)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
           _currentIndex = -1;
        }
    }
}
