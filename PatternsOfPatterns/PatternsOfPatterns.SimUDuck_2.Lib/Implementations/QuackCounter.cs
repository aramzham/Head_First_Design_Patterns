using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations
{
    // this is a decorator
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int NumberOfQuacks = 0;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }

        public void Quack()
        {
            _duck.Quack();
            NumberOfQuacks++;
        }

        public static int GetQuacks() 
        {
            return NumberOfQuacks;
        }
    }
}
