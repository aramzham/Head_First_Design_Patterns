using StarbuzzCoffee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost() => .20 + _beverage.Cost();

        public override string GetDescription() => $"{_beverage.GetDescription()}, Mocha";
    }
}
