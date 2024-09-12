using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPatternSample
{
    public class ConcreteObserver : IObserver
    {

        private string _name;

        private string _observerState;

        public ConcreteObserver(string name)
        {
            _name = name;
        }
        public void Update(string message)
        {
            _observerState = message;
            Console.WriteLine($"Observer {_name} has received an update: {_observerState}");
        }
    }
}
