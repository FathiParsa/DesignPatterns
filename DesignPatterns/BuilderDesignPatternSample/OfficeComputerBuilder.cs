using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternSample
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        public Computer _computer = new Computer();

        public Computer GetComputer()
        {
            return _computer;
        }

        public void SetCPU()
        {
            _computer.CPU = "Intel Core I5";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "Quadro M1000";
        }

        public void SetRAM()
        {
            _computer.RAM = "8 GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "512 SSD";
        }
    }
}
