using BakingWithOOGoodness.Lib.Implementations.Pizzas;
using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                // add more chicago style pizzas
                case "cheese": return new ChicagoStyleCheesePizza();
                default: return default(Pizza);
            }
        }
    }
}
