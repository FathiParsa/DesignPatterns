using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternSample
{
    public class Computer
    {
        public string RAM { get; set; }
        public string CPU { get; set; }
        public string GraphicsCard { get; set; }
        public string Storage { get; set; }

        public override string ToString()
        {
            return $"Processor: {CPU} , RAM: {RAM} , Storage: {Storage} , Graphic : {GraphicsCard}";
        }

    }
}
