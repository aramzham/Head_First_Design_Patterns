using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.Pizzas
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            Name = "NY Style Pepperoni Pizza";
            _dough = "This Crust Dough";
            _sauce = "Some pepperoni Sauce";

            _toppings.Add("topping for pepperoni");
        }
    }
}
