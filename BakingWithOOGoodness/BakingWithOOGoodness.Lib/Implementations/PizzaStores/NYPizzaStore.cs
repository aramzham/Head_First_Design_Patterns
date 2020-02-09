using BakingWithOOGoodness.Lib.Implementations.Pizzas;
using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese": return new NYStyleCheesePizza();
                case "vegie": return new NYStyleVeggiePizza();
                case "clam": return new NYStyleClamPizza();
                case "pepperoni": return new NYStylePepperoniPizza();
                default: return default(Pizza);
            }
        }
    }
}
