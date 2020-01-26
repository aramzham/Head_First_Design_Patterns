using MightyGumball.Lib.States;
using System;

namespace MightyGumball.Lib
{
    public class GumballMachine
    {
        private IState _hasQuarter;
        private IState _noQuarter;
        private IState _soldOut;
        private IState _sold;
        private IState _winner;

        private IState _currentState;

        private int _count = 0;

        public GumballMachine(int gumballCount)
        {
            _count = gumballCount;
            _soldOut = new SoldOutState(this);
            _noQuarter = new NoQuarterState(this);
            _hasQuarter = new HasQuarterState(this);
            _sold = new SoldState(this);
            _winner = new WinnerState(this);
            _currentState = _count > 0 ? _noQuarter : _soldOut;
        }

        public void InsertQuarter()
        {
            _currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarter;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarter;
        }

        public IState GetSoldState()
        {
            return _sold;
        }

        public IState GetSoldOutState() 
        {
            return _soldOut;
        }

        public IState GetWinnerState()
        {
            return _winner;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
                _count--;
        }

        public int GetCount()
        {
            return _count;
        }

        public void Refill(int count)
        {
            _count = count;
            _currentState = _noQuarter;
        }

        public override string ToString()
        {
            return $"C#-enabled Standing Gumball Model #2020\nInventory: {_count} gumballs\n{(_count > 0 ? "Machine is waiting for quarter" : "Machine is sold out")}";
        }
    }
}