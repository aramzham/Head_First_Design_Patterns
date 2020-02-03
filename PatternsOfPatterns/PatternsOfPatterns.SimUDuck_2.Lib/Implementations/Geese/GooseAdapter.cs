using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Geese
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }
    }
}
