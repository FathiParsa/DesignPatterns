using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternSample
{
    public class ObjectStructure
    {
        private List<IElement> _elements = new List<IElement>();

        public void Add(IElement element)
        {
            _elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }

    }
}
