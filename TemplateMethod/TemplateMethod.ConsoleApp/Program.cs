using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.ReadKey();
        }
    }
}
