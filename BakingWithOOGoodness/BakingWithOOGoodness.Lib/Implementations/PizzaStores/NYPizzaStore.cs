using BakingWithOOGoodness.Lib.Implementations.IngredientFactories;
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
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            var pizza = default(Pizza);
            // add more pizza classes
            switch (type)
            {
                case "cheese":
                    {
                        pizza = new CheesePizza(ingredientFactory);
                        pizza.Name = "New York Style Pizza";
                    }
                    break;
                case "vegie":
                    {
                        //pizza = new VeggiePizza(ingredientFactory);
                        //pizza.Name = "New York Style Veggie Pizza";
                    }
                    break;
                case "clam":
                    {
                        pizza = new ClamPizza(ingredientFactory);
                        pizza.Name = "New York Style Clam Pizza";
                    }
                    break;
                case "pepperoni":
                    {
                        //pizza = new PepperoniPizza(ingredientFactory);
                        //pizza.Name = "New York Style Pepperoni Pizza";
                    }
                    break;
            }

            return pizza;
        }
    }
}
