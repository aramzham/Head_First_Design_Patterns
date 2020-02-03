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

            Console.WriteLine("\nDuck Simulator: With Composite - Flocks");

            var flockOfDucks = new Flock();

            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(readheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);

            var flockOfMallards = new Flock();

            IQuackable mallard_1 = duckFactory.CreateMallardDuck();
            IQuackable mallard_2 = duckFactory.CreateMallardDuck();
            IQuackable mallard_3 = duckFactory.CreateMallardDuck();
            IQuackable mallard_4 = duckFactory.CreateMallardDuck();

            flockOfMallards.Add(mallard_1);
            flockOfMallards.Add(mallard_2);
            flockOfMallards.Add(mallard_3);
            flockOfMallards.Add(mallard_4);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            Simulate(flockOfMallards);

            Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
