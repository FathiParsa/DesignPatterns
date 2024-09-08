using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPatternSample
{
    public interface IDevice
    {
        void PowerOn();
        void PowerOff();
        void SetChannel(int channel);
    }
}
