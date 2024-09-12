using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternSample
{
    public class OnState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("The Machine is Now ON .");
            context.State = new OffState();
        }
    }
}
