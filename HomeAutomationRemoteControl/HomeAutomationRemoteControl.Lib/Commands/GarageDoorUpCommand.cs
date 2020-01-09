using HomeAutomationRemoteControl.Lib.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Commands
{
    public class GarageDoorUpCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
    }
}
