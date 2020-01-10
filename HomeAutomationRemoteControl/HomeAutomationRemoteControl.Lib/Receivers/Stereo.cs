using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class Stereo : ReceiverBase
    {


        public Stereo(string place) : base(place)
        {
        }

        public void On() 
        {
            Console.WriteLine($"Turn {_place} stereo on");
        }

        public void Off()
        {
            Console.WriteLine($"Turn {_place} stereo off");
        }

        public void SetCd()
        {
            Console.WriteLine($"Set CD");
        }

        public void SetDvd()
        {
            Console.WriteLine($"Set DVD");
        }

        public void SetRadio()
        {
            Console.WriteLine($"Set radio");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Set volume to {volume}");
        }
    }
}
