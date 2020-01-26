using MightyGumball.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MightyGumball.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballMachine = new GumballMachine(5);

            var i = 10;
            while (true)
            {
                while (i != 0)
                {
                    Console.WriteLine(gumballMachine);

                    gumballMachine.InsertQuarter();
                    gumballMachine.TurnCrank();

                    Console.WriteLine(gumballMachine);

                    i--;
                }

                Thread.Sleep(5000);
                gumballMachine.Refill(10);
            }

            Console.ReadKey();
        }
    }
}
