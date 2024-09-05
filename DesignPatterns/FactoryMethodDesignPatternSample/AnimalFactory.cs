using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPatternSample
{
    public abstract class AnimalFactory 
    {
        public abstract IAnimal CreateAnimal();
    }
}
