using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Implementations.IngredientFactories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public string CreateCheese()
        {
            return "Reggiano Cheese";
        }

        public string CreateClam()
        {
            return "Fresh Clam";
        }

        public string CreateDough()
        {
            return "Thin Crust Dough";
        }

        public string CreatePepperoni()
        {
            return "Sliced Pepperoni";
        }

        public string CreateSauce()
        {
            return "Marinara Sauce";
        }

        public string[] CreateVeggies()
        {
            return new[] {"Garlic","Onion","Mushroom","RedPepper" };
        }
    }
}
