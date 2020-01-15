using System;

namespace BeingAdaptive.FacadeLib
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Dvd player is on");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Playing \"{movie}\" in dvd player");
        }

        public void Stop()
        {
            Console.WriteLine("Dvd player is stopped");
        }

        public void Eject()
        {
            Console.WriteLine("Dvd player is ejected");
        }

        public void Off()
        {
            Console.WriteLine("Dvd player is off");
        }
    }
}