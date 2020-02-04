using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Interfaces
{
    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }
}
