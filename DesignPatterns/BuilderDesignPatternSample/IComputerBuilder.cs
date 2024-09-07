using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternSample
{
    public interface IComputerBuilder
    {
        void SetRAM();
        void SetCPU();
        void SetGraphicsCard();
        void SetStorage();
        Computer GetComputer();
    }
}
