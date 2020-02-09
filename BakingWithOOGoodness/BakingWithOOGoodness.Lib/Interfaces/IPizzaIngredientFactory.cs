using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        string CreateDough();
        string CreateSauce();
        string CreateCheese();
        string[] CreateVeggies();
        string CreatePepperoni();
        string CreateClam();
    }
}
