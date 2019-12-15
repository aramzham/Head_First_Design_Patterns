using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Common.Interfaces
{
    public abstract class Duck
    {
        protected FlyBehavior _flyBehavior;
        protected QuackBehavior _quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly() 
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim() 
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void SetQuackBehavior(QuackBehavior qb)
        {
            _quackBehavior = qb;
        }
    }
}
