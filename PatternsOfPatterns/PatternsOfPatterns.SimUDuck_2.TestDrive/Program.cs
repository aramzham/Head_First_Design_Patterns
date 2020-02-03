using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Ducks;
using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Geese;
using PatternsOfPatterns.SimUDuck_2.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOfPatterns.SimUDuck_2.TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulate();

            Console.ReadKey();
        }

        private static void Simulate()
        {
            IQuackable mallardDuck = new MallardDuck();
            IQuackable readheadDuck = new ReadheadDuck();
            IQuackable duckCall = new DuckCall();
            IQuackable rubberDuck = new RubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator: With Goose Adapter");

            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
