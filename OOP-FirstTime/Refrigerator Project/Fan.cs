using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Fan : Refrigerators
    {
        public Fan(double temperature, string RefrigeratorColor) : base(temperature, RefrigeratorColor)
        {
            ValidateTemperature();
            FanMode();

        }

        public override double ValidateTemperature()
        {
            if (Temperature >= 1 && Temperature <=3)
            {
                return Temperature;
            }
            else
            {
                return Temperature = 0;
            }
        }

        public override bool FanMode()
        {
            if (Temperature == 0)
            {
                return FanIsOn = false;
            }
            else
            {
                return FanIsOn = true;
            }
        }

        public override void HigherTemperature()
        {
            Temperature++;
            ValidateTemperature();
            FanMode();
        }

        public override void LowerTemperature()
        {
            Temperature--;
            ValidateTemperature();
            FanMode();
        }

        public override string ValidateText()
        {
            if (FanIsOn)
            {
                return $"The fan is at {Temperature} speed";
            }
            else
            {
                return $"The fan isn't working";
            }

        }

        public override string Result()
        {
            string validateText = ValidateText();
            return $"{validateText}. It's color is {RefrigeratorColor}.";
        }
    }
}
