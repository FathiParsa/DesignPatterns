using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternSample
{
    public class Adaptee 
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Sepcific Request in Adaptee");
        }
    }
}
