using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class Light : ReceiverBase
    {
        public Light(string place) : base(place)
        {
        }

        public void On() 
        {
            Console.WriteLine($"Turn the {_place} light on");
        }

        public void Off()
        {
            Console.WriteLine($"Turn the {_place} light off");
        }
    }
}
