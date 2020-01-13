using BeingAdaptive.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeingAdaptive.Lib.Implementations
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Turkey is flying, but not so far");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble, gobble...");
        }
    }
}
