using System;
using System.Collections.Generic;
using System.Text;

namespace BeingAdaptive.FacadeLib
{
    public class HomeTheaterFacade
    {
        private Amplifier _amp;
        private Tuner _tuner;
        private DvdPlayer _dvd;
        private CdPlayer _cd;
        private Projector _projector;
        private TheaterLights _lights;
        private Screen _screen;
        private PopcornPopper _popper;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer, CdPlayer cdPlayer, Projector projector, TheaterLights theaterLights, Screen screen, PopcornPopper popcornPopper)
        {
            _amp = amplifier;
            _tuner = tuner;
            _dvd = dvdPlayer;
            _cd = cdPlayer;
            _projector = projector;
            _lights = theaterLights;
            _screen = screen;
            _popper = popcornPopper;
        }

        public void WatchMovie(string movie) 
        {
            Console.WriteLine("Get ready to watch a movie...");

            _popper.On();
            _popper.Pop();

            _lights.Dim(10);

            _screen.Down();

            _projector.On();
            _projector.SetInput(_dvd);
            _projector.WideScreenMode();

            _amp.On();
            _amp.SetDvd(_dvd);
            _amp.SetSurroundSound();
            _amp.SetVolume(15);

            _dvd.On();
            _dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");

            _popper.Off();
            _lights.On();
            _screen.Up();
            _projector.Off();
            _amp.Off();
            _dvd.Stop();
            _dvd.Eject();
            _dvd.Off();
        }
    }
}
