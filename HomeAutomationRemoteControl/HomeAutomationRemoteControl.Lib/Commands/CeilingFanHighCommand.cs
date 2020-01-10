using HomeAutomationRemoteControl.Lib.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Commands
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
        }

        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.HIGH: _ceilingFan.High(); break;
                case CeilingFan.MEDIUM: _ceilingFan.Medium(); break;
                case CeilingFan.LOW: _ceilingFan.Low(); break;
                case CeilingFan.OFF: _ceilingFan.Off(); break;
            }
        }
    }
}
