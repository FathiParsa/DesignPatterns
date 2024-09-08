using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternSample
{
    public class Radio : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("Radio is Now OFF");
        }

        public void PowerOn()
        {
                Console.WriteLine("Radio is Now ON.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Radio Channel Set To {channel}");
        }
    }
}
