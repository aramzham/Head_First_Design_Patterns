using System;
using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist: {duck} just quacked.");
        }
    }
}