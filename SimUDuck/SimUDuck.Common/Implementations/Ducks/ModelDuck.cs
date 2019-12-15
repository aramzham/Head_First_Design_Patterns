using SimUDuck.Common.Implementations.Fly;
using SimUDuck.Common.Implementations.Quack;
using SimUDuck.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Common.Implementations.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackSimple();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }        
    }
}
