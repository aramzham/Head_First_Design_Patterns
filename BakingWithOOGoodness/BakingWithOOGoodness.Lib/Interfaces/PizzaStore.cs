using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Interfaces
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // factory method
        public abstract Pizza CreatePizza(string type);
    }
}
