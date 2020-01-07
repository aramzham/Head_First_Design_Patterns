using System;
using System.Collections.Generic;
using System.Text;

namespace ChocOHolic.Lib
{
    public class EagerSingleton
    {
        private static EagerSingleton eagerSingleton = new EagerSingleton();

        private EagerSingleton()
        {

        }

        public static EagerSingleton GetInstance()
        {
            return eagerSingleton;
        }
    }
}
