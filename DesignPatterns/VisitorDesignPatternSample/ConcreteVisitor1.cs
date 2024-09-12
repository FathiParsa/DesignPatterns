using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternSample
{
    public class ConcreteVisitor1 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"{element.OperationA()} visited by ConcreteVisitor1");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"{element.OperationB()} visited by ConcreteVisitor1");
        }
    }
}
