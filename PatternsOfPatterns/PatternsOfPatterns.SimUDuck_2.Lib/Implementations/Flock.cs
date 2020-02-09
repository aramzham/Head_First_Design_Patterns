using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations
{
    public class Flock : IQuackable
    {
        private List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            foreach (var quacker in _quackers)
            {
                quacker.Quack();
            }

            //var iterator = _quackers.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    var quacker = iterator.Current;
            //    quacker?.Quack();
            //}
        }

        public void RegisterObserver(IObserver observer)
        {
            foreach (var quackable in _quackers)
            {
                quackable.RegisterObserver(observer);
            }
        }

        public void NotifyObservers() { }
    }
}
