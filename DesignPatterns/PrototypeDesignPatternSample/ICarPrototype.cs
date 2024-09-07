using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternSample
{
    public interface ICarPrototype
    {
        ICarPrototype Clone();
    }
}
