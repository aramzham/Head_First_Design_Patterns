using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.Pizzas
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Vegie Pizza";
            _dough = "This Crust Dough";
            _sauce = "Some vegie Sauce";

            _toppings.Add("Grated Reggiano Cheese");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
