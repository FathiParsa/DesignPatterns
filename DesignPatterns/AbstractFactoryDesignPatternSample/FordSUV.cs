using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public class FordSUV : ISUV
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Ford SUV is : Raptor");
        }
    }
}
