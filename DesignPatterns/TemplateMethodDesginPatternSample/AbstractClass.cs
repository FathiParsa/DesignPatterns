using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesginPatternSample
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Hook();
            Step3();
        }

        protected abstract void Step1();
        protected abstract void Step2();
        protected abstract void Step3();
        protected virtual void Hook() { }
    }
}
