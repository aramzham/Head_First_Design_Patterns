using System;

namespace ChocOHolic.Lib
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler chocolateBoiler;

        public bool IsEmpty { get; private set; }
        public bool IsBoiled { get; private set; }

        private ChocolateBoiler()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        public static ChocolateBoiler GetInstance() 
        {
            if (chocolateBoiler is null)
                chocolateBoiler = new ChocolateBoiler();

            return chocolateBoiler;
        }

        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
                IsBoiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }

        public void Drain()
        {
            if (!IsEmpty && IsBoiled)
            {
                // drain the boiled milk and chocolate
                IsEmpty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !IsBoiled) {
                // bring the contents to a boil
                IsBoiled = true;
            }
        }
    }
}
