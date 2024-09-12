using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesginPatternSample
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("ConcreteClassB : Execute Step 1");
        }

        protected override void Step2()
        {
            Console.WriteLine("ConcreteClassB : Execute Step 2");
        }

        protected override void Step3()
        {
            Console.WriteLine("ConcreteClassB : Execute Step 3");
        }

        protected override void Hook()
        {
            Console.WriteLine("ConcreteClassB : Execute Step Virtual");
        }
    }
}
