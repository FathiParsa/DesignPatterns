using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternSample
{
    public class TextHistory
    {
        private Stack<TextMemento> _history = new Stack<TextMemento>();
        public void SaveState(TextMemento memento)
        {
            _history.Push(memento);
        }

        public TextMemento Undo()
        {
            if (_history.Count > 0 )
            {
                return _history.Pop();
            }
            return null;
        }
    }
}
