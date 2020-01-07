using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChocOHolic.Lib
{
    public class SynchronizedChocolateBoiler
    {
        private static SynchronizedChocolateBoiler synchronizedChocolateBoiler;

        public bool IsEmpty { get; private set; }
        public bool IsBoiled { get; private set; }

        private SynchronizedChocolateBoiler()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static SynchronizedChocolateBoiler GetInstance()
        {
            if (synchronizedChocolateBoiler is null)
                synchronizedChocolateBoiler = new SynchronizedChocolateBoiler();

            return synchronizedChocolateBoiler;
        }
    }
}
