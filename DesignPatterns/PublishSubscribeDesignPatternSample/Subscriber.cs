using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribeDesignPatternSample
{
    public class Subscriber
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void OnDataReceived(object sender , string data)
        {
            Console.WriteLine($"{_name} : Received data '{data}' ");
        }
    }
}
