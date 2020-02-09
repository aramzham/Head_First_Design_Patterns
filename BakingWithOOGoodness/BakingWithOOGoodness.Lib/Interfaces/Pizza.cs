using System;
using System.Collections.Generic;
using System.Text;

namespace BakingWithOOGoodness.Lib.Interfaces
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();
        protected string[] _veggies;
        protected string _cheese;
        protected string _pepperoni;
        protected string _clam;

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public abstract void Prepare();
    }
}
