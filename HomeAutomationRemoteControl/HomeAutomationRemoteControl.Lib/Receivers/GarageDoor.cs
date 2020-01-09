using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class GarageDoor : ReceiverBase
    {
        public GarageDoor(string place) : base(place)
        {
        }

        public void Up()
        {
            Console.WriteLine("Open the garage door");
        }

        public void Down()
        {
            Console.WriteLine("Close the garage door");
        }
    }
}
