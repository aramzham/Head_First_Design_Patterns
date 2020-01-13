using BeingAdaptive.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeingAdaptive.Lib
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly(); // to fly like a duck
            }
        }

        public void Quack()
        {
            _turkey.Gobble(); // imitate quack :)
        }
    }
}
