using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Lib.Abstracts
{
    public abstract class CaffeineBeverageWithHook
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
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

        protected virtual bool CustomerWantsCondiments() 
        {
            return true;
        }
    }
}
