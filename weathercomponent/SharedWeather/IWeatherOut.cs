using System;

namespace weathercomponent
{
    public interface IWeatherOut
    {
        public WeatherInfo GetWeatherInfo();
        
        public void SetWeatherInfo(WeatherInfo x);

    }
}