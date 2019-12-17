using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama.Common.Interfaces
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
