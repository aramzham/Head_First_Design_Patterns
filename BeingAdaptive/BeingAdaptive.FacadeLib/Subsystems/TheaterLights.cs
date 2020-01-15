using System;

namespace BeingAdaptive.FacadeLib
{
    public class TheaterLights
    {
        public void Dim(int value)
        {
            Console.WriteLine($"Theater lights is dimmed to {value}");
        }

        public void On()
        {
            Console.WriteLine("Theater lights is on");
        }
    }
}