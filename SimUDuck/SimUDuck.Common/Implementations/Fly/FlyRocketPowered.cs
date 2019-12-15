using SimUDuck.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Common.Implementations.Fly
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
