using SimUDuck.Common.Implementations.Fly;
using SimUDuck.Common.Implementations.Quack;
using SimUDuck.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Common.Implementations.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new QuackSimple();
            _flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
