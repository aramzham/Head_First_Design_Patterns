using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class CeilingFan : ReceiverBase
    {
        public CeilingFan(string place) : base(place)
        {
        }

        public void On()
        {
            Console.WriteLine($"Turn the {_place} ceiling fan on");
        }

        public void Off()
        {
            Console.WriteLine($"Turn the {_place} ceiling fan off");
        }
    }
}
