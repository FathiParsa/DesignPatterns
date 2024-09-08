using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPatternSample
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _decoratedCoffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _decoratedCoffee = coffee;
        }

        public virtual double GetCost()
        {
            return _decoratedCoffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _decoratedCoffee.GetDescription();
        }
    }
}
