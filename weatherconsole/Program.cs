using System;
using weathercomponent;
namespace weatherconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            weatherin w = new weatherin();
           
            WeatherManager managerweather = new WeatherManager(w);
            managerweather.StartCollect();
            //managerweather.Display.WriteWeatherValue("temp", "10
            var x=Console.ReadLine();
        }

        
    }
}

