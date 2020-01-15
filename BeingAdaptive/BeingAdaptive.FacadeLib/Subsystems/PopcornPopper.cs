using System;

namespace BeingAdaptive.FacadeLib
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper is on");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn is popping");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper is off");
        }
    }
}