using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
