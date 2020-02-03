using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Geese;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Interfaces
{
    public abstract class AbstractGooseFactory
    {
        public abstract Goose CreateGoose();
    }
}
