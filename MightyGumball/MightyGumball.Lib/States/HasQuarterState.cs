using System;
using System.Collections.Generic;
using System.Text;

namespace MightyGumball.Lib.States
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random _randomWinner = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = _randomWinner.Next(10);
            if (winner == 0 && _gumballMachine.GetCount() > 1)
                _gumballMachine.SetState(_gumballMachine.GetWinnerState());
            else
                _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }
    }
}
