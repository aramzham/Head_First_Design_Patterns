using StarbuzzCoffee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }
        public override double Cost() => .89;
    }
}
