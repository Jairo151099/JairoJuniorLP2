using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TemperaturaCelsius
    {
        public double valor;
        public double convertF()
        {
            return valor * 1.8 + 32;
        }
        public double convertK()
        {
            return valor + 273;
        }
    }
}