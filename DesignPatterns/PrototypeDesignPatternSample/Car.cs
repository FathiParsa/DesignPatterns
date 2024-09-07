using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternSample
{
    public class Car : ICarPrototype
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public int EngineCapacity { get; set; }

        public Car(string name , string model , int engineCapacity)
        {
            Name = name;    
            Model = model;
            EngineCapacity = engineCapacity;
        }

        public ICarPrototype Clone()
        {
            return (ICarPrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name : {Name} , Model : {Model} , EngineCapacity : {EngineCapacity} cc";
        }

    }
}
