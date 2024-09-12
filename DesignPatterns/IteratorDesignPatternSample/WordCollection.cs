using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternSample
{
    public class WordCollection : IEnumerable
    {
        private ArrayList _words = new ArrayList();
        
        public void AddWord(string word)
        {
            _words.Add(word);
        }
        
        public IEnumerator GetEnumerator()
        {
            return new WordIterator(this);
        }

        public int Count => _words.Count;

        public string this[int index]
        {
            get { return _words[index] as string; }

        }
    }
}
