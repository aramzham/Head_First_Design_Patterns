using System;
using System.Collections.Generic;
using System.Text;

namespace WellManagedCollections.Lib
{
    public class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _isVegetarian;
        private double _price;

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            _name = name;
            _description = description;
            _isVegetarian = isVegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine($" {GetName()}");
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }

            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"   -- {GetDescription()}");
        }
    }
}
