using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.Pizzas
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "NY Style Clam Pizza";
            _dough = "This Crust Dough";
            _sauce = "Some clam Sauce";

            _toppings.Add("topping for clam");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
