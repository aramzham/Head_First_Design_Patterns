using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class CeilingFan : ReceiverBase
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        private int _speed;

        public CeilingFan(string place) : base(place)
        {
            _speed = OFF;
        }

        public void On()
        {
            Console.WriteLine($"Turn the {_place} ceiling fan on");
        }

        public void Off()
        {
            _speed = OFF;
            Console.WriteLine($"Turn the {_place} ceiling fan off");
        }

        public void High() { _speed = HIGH;
        // other code
        }
        public void Medium() { _speed = MEDIUM;
        // other code
        }
        public void Low() { _speed = LOW; 
        // other code
        }

        public int GetSpeed() => _speed;
    }
}
