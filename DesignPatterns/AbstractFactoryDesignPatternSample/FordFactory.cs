using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternSample
{
    public class FordFactory : ICarFactory
    {
        public ISedan CreateSedan()
        {
            return new FordSedan();
        }

        public ISUV CreateSUV()
        {
            return new FordSUV();
        }
    }
}
