using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            // do not execute anything
        }
    }
}
