﻿using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Ducks
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Mallard quacks");
        }
    }
}
