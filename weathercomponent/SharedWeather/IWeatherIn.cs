using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weathercomponent
{
   public interface IWeatherIn
    {
        public void WriteWeatherValue(string valueType, string value);
    }
}
