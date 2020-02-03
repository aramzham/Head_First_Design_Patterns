using PatternsOfPatterns.SimUDuck_2.Lib.Implementations;
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
            IQuackable mallardDuck = new QuackCounter(new MallardDuck());
            IQuackable readheadDuck = new QuackCounter(new ReadheadDuck());
            IQuackable duckCall = new QuackCounter(new DuckCall());
            IQuackable rubberDuck = new QuackCounter(new RubberDuck());
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator: With Goose Adapter");

            Simulate(mallardDuck);
            Simulate(readheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
