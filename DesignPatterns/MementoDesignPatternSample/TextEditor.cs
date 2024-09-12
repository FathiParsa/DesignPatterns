using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPatternSample
{
    public class TextEditor
    {
        public string _text;
        public void SetText(String text)
        {
            _text = text;
        }
        public string GetText()
        {
            return _text;
        }

        public TextMemento Save()
        {
            return new TextMemento(_text);
        }
        public void Restore(TextMemento memento)
        {
            _text = memento.Text;
        }
    }
}










