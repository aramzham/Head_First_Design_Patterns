using System;
using System.Collections.Generic;
using System.Text;

namespace MightyGumball.Lib.States
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no gumball");
        }
    }
}
