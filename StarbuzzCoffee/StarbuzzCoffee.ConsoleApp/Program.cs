using StarbuzzCoffee.Common.Beverages;
using StarbuzzCoffee.Common.Condiments;
using StarbuzzCoffee.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbuzzCoffee.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage1 = new HouseBlend();
            beverage1 = new Soy(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");

            Console.ReadLine();
        }
    }
}
