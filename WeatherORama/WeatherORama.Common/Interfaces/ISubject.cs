using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherORama.Common.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
