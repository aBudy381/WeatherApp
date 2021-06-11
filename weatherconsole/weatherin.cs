using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weathercomponent;
namespace weatherconsole
{
   public class weatherin:IWeatherIn
    {
        public void WriteWeatherValue(string valueType, string value)
        {
            Console.WriteLine(valueType + ": " + value);
        }
    }
}
