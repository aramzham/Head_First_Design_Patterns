using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Ducks
{
    public class RubberDuck : IQuackable
    {
        private Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public override string ToString()
        {
            return "Rubber Duck";
        }
    }
}
