using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAutomationRemoteControl.Lib.Receivers
{
    public class ReceiverBase
    {
        protected string _place;

        public ReceiverBase(string place)
        {
            _place = place;
        }
    }
}
