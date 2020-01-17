using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Lib.Abstracts;

namespace TemplateMethod.Lib.Concretes
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
