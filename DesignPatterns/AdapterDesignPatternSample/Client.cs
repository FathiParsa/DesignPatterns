using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternSample
{
    public class Client 
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }

        public void Execute()
        {
            _target.Request();
        }
    }
}
