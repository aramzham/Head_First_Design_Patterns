using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellManagedCollections.Lib;

namespace WellManagedCollections.TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakeHouseMenu = new Menu("Pancake House Menu", "Breakfast");
            var dinerMenu = new Menu("Diner Menu", "Lunch");
            var cafeMenu = new Menu("Cafe Menu", "Dinner");
            var dessertMenu = new Menu("Dessert Menu", "Dessert of course!");

            var allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie","Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59));

            var waitress = new Waitress(allMenus);

            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
