using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public class ToyotaSedan : ISedan
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Toyota Sedan is : Corolla");
        }
    }
}
