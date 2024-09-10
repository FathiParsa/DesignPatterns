using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternSample
{
    public abstract class ComplaintHandler
    {
        protected ComplaintHandler _nextHandler;

        public void SetNextHandler(ComplaintHandler nextHandler)
        {
            this._nextHandler = nextHandler;
        }
        public abstract void HandleComplaint(string complaint, int severityLevel);
    }
}
