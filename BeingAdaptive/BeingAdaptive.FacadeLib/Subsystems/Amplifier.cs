using System;

namespace BeingAdaptive.FacadeLib
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("Amplifier is set to dvd");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Surround sound is set in amplifier");
        }

        public void SetVolume(int value)
        {
            Console.WriteLine($"Volume is set to {value} in amplifier");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off");
        }
    }
}