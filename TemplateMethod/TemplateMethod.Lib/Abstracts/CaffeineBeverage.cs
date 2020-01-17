using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Lib.Abstracts
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boil water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pour into cup");
        }
    }
}
