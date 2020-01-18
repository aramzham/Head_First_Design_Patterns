using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Lib;
using TemplateMethod.Lib.Concretes;

namespace TemplateMethod.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            var coffeeHook = new CoffeeWithHook();
            Console.WriteLine("\nMaking coffee...");
            coffeeHook.PrepareRecipe();

            var ducks = new Duck[]
            {
                new Duck("Daffy",8 ),
                new Duck("Dewey",2 ),
                new Duck("Howard",7 ),
                new Duck("Louie",2 ),
                new Duck("Donald",10 ),
                new Duck("Huey",2 ),
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);

            Console.ReadKey();
        }

        private static void Display(Duck[] ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck);
            }
        }
    }
}
