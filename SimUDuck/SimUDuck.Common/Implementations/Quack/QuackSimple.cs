using SimUDuck.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Common.Implementations.Quack
{
    public class QuackSimple : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Simply quacking...");
        }
    }
}
