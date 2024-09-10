using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternSample
{
    public class MidLevelHandler : ComplaintHandler
    {
        public override void HandleComplaint(string complaint, int severityLevel)
        {
            if (severityLevel <= 3)
            {
                Console.WriteLine($"MidLevelHandler Handled The Complaint {complaint}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleComplaint(complaint, severityLevel);
            }
        }
    }
}
