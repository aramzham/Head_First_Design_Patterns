using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Interfaces
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
