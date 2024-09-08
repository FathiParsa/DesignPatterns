using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternSample
{
    public class AdvanceRemoteControl : RemoteControl
    {

        public AdvanceRemoteControl(IDevice device) : base(device) { }

        public override void TurnOff()
        {
            Console.WriteLine("Advance Remote : Turning Off The Device. ");
            device.PowerOff();
        }

        public override void TurnOn()
        {
            Console.WriteLine("Advance Remote : Turning On the Device. ");
            device.PowerOn();
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Advance Remote : Setting Channel to {channel}");
            device.SetChannel(channel);
        }
    }
}
