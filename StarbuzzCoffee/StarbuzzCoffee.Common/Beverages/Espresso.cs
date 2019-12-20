using StarbuzzCoffee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost() => 1.99;
    }
}
