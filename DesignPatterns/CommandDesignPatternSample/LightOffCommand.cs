using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternSample
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();

        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }
}
