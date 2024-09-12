using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPatternSample
{
    public class TelevisionOnCommand : ICommand
    {
        private readonly Television _television;
        public TelevisionOnCommand(Television television)
        {
            _television = television;
        }
        public void Execute()
        {
            _television.TurnOn();
        }

        public void Undo()
        {
            _television.TurnOff();
        }
    }
}
