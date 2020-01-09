using HomeAutomationRemoteControl.Lib.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib
{
    public class RemoteControl
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            var noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) 
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonPressed(int slot) 
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonPressed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n------------Remote Control -------------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {_onCommands[i].GetType().Name}  {_offCommands[i].GetType().Name}\n");
            }
            return sb.ToString();
        }
    }
}
