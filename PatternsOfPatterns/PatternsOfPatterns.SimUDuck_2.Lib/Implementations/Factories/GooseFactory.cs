using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Geese;
using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Factories
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override Goose CreateGoose()
        {
            return new Goose();
        }
    }
}
