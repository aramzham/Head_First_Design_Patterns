using BeingAdaptive.Lib;
using BeingAdaptive.Lib.Implementations;
using BeingAdaptive.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeingAdaptive.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says...");
            TestTheDuck(duck);

            Console.WriteLine("\nThe turkeyAdapter says...");
            TestTheDuck(turkeyAdapter);

            Console.ReadKey();
        }

        private static void TestTheDuck(IDuck duck) 
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
