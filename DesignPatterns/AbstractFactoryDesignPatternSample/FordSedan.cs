using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public class FordSedan : ISedan
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Ford Sedan is : Fusion");
        }
    }
}
