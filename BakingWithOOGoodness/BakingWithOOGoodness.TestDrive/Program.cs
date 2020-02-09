using BakingWithOOGoodness.Lib.Implementations.PizzaStores;
using BakingWithOOGoodness.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingWithOOGoodness.TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"You ordered a {pizza.Name}\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Another ordered pizza is {pizza.Name}\n");

            Console.ReadKey();
        }
    }
}
