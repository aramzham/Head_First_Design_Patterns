using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Lib.Abstracts;

namespace TemplateMethod.Lib.Concretes
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
