using System;
using System.Collections.Generic;
using System.Text;

namespace StarbuzzCoffee.Common.Interfaces
{
    public abstract class Beverage
    {
        protected string _description = "Unknown beverage";

        public string GetDescription() 
        {
            return _description;
        }

        public abstract double Cost();
    }
}
