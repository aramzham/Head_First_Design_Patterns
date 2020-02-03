using PatternsOfPatterns.SimUDuck_2.Lib.Implementations;
using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Ducks;
using PatternsOfPatterns.SimUDuck_2.Lib.Implementations.Factories;
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
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            AbstractGooseFactory gooseFactory = new GooseFactory();
            Simulate(duckFactory, gooseFactory);

            Console.ReadKey();
        }

        private static void Simulate(AbstractDuckFactory duckFactory, AbstractGooseFactory gooseFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable readheadDuck = duckFactory.CreateReadheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(gooseFactory.CreateGoose());

            Console.WriteLine("\nDuck Simulator: With Abstract Factory");

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
