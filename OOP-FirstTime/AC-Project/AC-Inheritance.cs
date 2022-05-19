using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Project
{
    abstract class Refrigerator
    {
        public Refrigerator(double temperature, string refrigeratorColor)
        {
            Temperature = temperature;
            RefrigeratorColor = refrigeratorColor;
        }


        public double Temperature { get; protected set; }
        public string FanIsOn { get; protected set; }
        public string RefrigeratorColor { get; protected set; }

        public virtual void UpTemperature()
        {
            Temperature += 1;
        }

        public virtual void DownTemperature()
        {
            Temperature -= 1;
        }


        public abstract string IsWorking();
        public abstract string Result();
    }
}
