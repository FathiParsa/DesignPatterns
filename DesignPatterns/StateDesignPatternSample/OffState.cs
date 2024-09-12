using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternSample
{
    public class OffState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("The Machine in now OFF");
            context.State = new OnState();
        }
    }
}
