using HomeAutomationRemoteControl.Lib.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        private Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11); // Why 11? Well, it's better than 10, right?
        }
    }
}
