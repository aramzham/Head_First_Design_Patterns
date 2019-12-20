using StarbuzzCoffee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Condiments
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost() => .15 + _beverage.Cost();

        public override string GetDescription() => $"{_beverage.GetDescription()}, Soy";
    }
}
