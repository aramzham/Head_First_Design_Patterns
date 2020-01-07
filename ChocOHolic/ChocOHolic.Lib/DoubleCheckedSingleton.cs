using System;
using System.Collections.Generic;
using System.Text;

namespace ChocOHolic.Lib
{
    public class DoubleCheckedSingleton
    {
        private volatile static DoubleCheckedSingleton doubleCheckedSingleton;
        private static object padlock = new object();

        private DoubleCheckedSingleton()
        {

        }

        public static DoubleCheckedSingleton GetInstance()
        {
            if (doubleCheckedSingleton is null) 
            {
                lock (padlock)
                {
                    if (doubleCheckedSingleton is null)
                    {
                        doubleCheckedSingleton = new DoubleCheckedSingleton();
                    }
                }
            }

            return doubleCheckedSingleton;
        }
    }
}
