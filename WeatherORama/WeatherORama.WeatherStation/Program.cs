using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WeatherORama.Common.Implementations;
using WeatherORama.Common.Implementations.Displays;

namespace WeatherORama.WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            // add other displays

            weatherData.SetMeasurements(80, 65, 30.4f);
            Thread.Sleep(3000);
            weatherData.SetMeasurements(82, 70, 29.2f);
            Thread.Sleep(3000);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
