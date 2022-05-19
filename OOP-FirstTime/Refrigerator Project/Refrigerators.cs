using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    abstract class Refrigerators
    {
        public Refrigerators(double temperature, string refrigeratorColor)
        {
            Temperature = temperature;
            RefrigeratorColor = refrigeratorColor;
        }


        public double Temperature { get; protected set; }
        public bool FanIsOn { get; protected set; }
        public string RefrigeratorColor { get; protected set; }

        public virtual void HigherTemperature()
        {
            Temperature += 1;
        }

        public virtual void LowerTemperature()
        {
            Temperature -= 1;
        }

        public abstract bool FanMode();
        public abstract double ValidateTemperature();
        public abstract string ValidateText();
        public abstract string Result();
    }
}
