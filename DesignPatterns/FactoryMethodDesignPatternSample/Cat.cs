using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternSample
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("MEOWWWWW  MEOWWWWW"); ;
        }
    }
}
