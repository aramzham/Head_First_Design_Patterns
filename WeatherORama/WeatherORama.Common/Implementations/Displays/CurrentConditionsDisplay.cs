using System;
using System.Collections.Generic;
using System.Text;
using WeatherORama.Common.Interfaces;

namespace WeatherORama.Common.Implementations.Displays
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject subject)
        {
            _weatherData = subject;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
