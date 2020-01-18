using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Lib
{
    public class Duck : IComparable
    {
        public int Weight { get; private set; }
        public string Name { get; private set; }

        public Duck(string name, int weight)
        {
            Weight = weight;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Duck otherDuck))
                throw new ArgumentException("the argument was not a duck");

            if (this.Weight < otherDuck.Weight)
                return -1;
            else if (this.Weight == otherDuck.Weight)
                return 0;
            else
                return 1;
        }

        public override string ToString()
        {
            return $"{this.Name} weights {this.Weight}";
        }
    }
}
