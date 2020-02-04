using System.Collections.Generic;
using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            using (var iterator = _observers.GetEnumerator())
            {
                while (iterator.MoveNext())
                {
                    var observer = iterator.Current;
                    observer?.Update(_duck);
                }
            }
        }
    }
}