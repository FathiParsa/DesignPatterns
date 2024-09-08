using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternSample
{
    public class TV : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("TV is Now OFF.");
        }

        public void PowerOn()
        {
            Console.WriteLine("TV is Now ON.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"TV Chanel Set To {channel}");
        }
    }
}
