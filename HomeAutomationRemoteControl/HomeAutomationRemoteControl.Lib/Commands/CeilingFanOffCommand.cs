using HomeAutomationRemoteControl.Lib.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Commands
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _ceilingFan.Off();
        }
    }
}
