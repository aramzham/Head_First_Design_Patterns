using BeingAdaptive.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeingAdaptive.Lib.Implementations
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Duck flies...");
        }

        public void Quack()
        {
            Console.WriteLine("Duck quacks");
        }
    }
}
