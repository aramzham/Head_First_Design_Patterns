using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            _dough = "This Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Grated Reggiano Cheese");
        }
    }
}
