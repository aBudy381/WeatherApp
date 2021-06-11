using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using weathercomponent.BuisinessWeather;

namespace weathercomponent
{
    public class WeatherManager : IWeatherOut
    {
        private Random r = new Random(10);

        private WeatherInfo info;
        private WeatherValue value;
        private IWeatherIn display;

        public WeatherInfo Info { get => info; set => info = value; }
        internal WeatherValue Value { get => value; set => this.value = value; }
        public IWeatherIn Display { get => display; set => display = value; }

        public WeatherManager(IWeatherIn x)
        {

            this.Display = x;
            info = new WeatherInfo();
            value = new WeatherValue();
        }
        public WeatherInfo GetWeatherInfo()
        { return Info; }

        public void SetWeatherInfo(WeatherInfo x)
        { this.Info = x; }


        public void StartCollect()
        {
            Timer t1 = new Timer(GetTemperature);
            t1.Change(5000, 5000);
            Timer t2 = new Timer(GetWind);
            t2.Change(5000, 5000);
            Timer t3 = new Timer(GetPrecepitation);
            t3.Change(5000, 5000);
            Timer t4 = new Timer(GetPression);
            t4.Change(5000, 5000);

        }
        public void GetTemperature(object state)
        {
           
            int temp = r.Next();
            Display.WriteWeatherValue("temperature", temp.ToString());
        }
        public void GetWind(object state)
        {
            
            int w = r.Next();
            Display.WriteWeatherValue("wind", w.ToString());
        }
        public void GetPrecepitation(object state)
        {
            
            int pre = r.Next();
            Display.WriteWeatherValue("temperature", pre.ToString());
        }
        public void GetPression(object state)
        {
           
            int pres = r.Next();
            Display.WriteWeatherValue("wind", pres.ToString());
        }

    }

}
