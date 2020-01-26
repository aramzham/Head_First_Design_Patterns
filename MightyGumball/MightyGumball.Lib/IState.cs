using System;
using System.Collections.Generic;
using System.Text;

namespace MightyGumball.Lib
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
