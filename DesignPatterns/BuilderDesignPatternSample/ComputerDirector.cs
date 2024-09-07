using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternSample
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildComputer()
        {
            _builder.SetGraphicsCard();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetCPU();

        }

        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }


    }
}
