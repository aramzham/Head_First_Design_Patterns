using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Lib.Abstracts;

namespace TemplateMethod.Lib.Concretes
{
    public class CoffeeWithHook : CaffeineBeverageWithHook
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();

            if (answer.ToLower().StartsWith("y"))
                return true;
            else
                return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            var answer = Console.ReadLine();
            return string.IsNullOrEmpty(answer) || answer.StartsWith("n") ? "no" : "yes";
        }
    }
}
