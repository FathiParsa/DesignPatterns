using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternSample
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public Computer GetComputer()
        {
            return _computer;
            
        }

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i9";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "RTX 3080Ti";
        }

        public void SetRAM()
        {
            _computer.RAM = "16 GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "1TB SSD M2";
        }
    }
}
