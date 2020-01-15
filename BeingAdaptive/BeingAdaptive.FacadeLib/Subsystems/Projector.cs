using System;

namespace BeingAdaptive.FacadeLib
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on");
        }

        public void SetInput(DvdPlayer dvd)
        {
            Console.WriteLine("Input is set on dvd in projector");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector is set on widescreen mode");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off");
        }
    }
}