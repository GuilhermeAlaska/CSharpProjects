using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Project
{
    class Fan : Refrigerator
    {
        public Fan(double temperature, string refrigeratorColor) : base(temperature, refrigeratorColor)
        {
            IsWorking();
           
        }

        public override string IsWorking()
        {
            if (Temperature >= 3)
            {
                Temperature = 3;
                return FanIsOn = "on";
            }
            else if (Temperature >= 1 && Temperature <= 2)
            {
                return FanIsOn = "on";
            }
            else
            {
                return FanIsOn = "off";
                Temperature = 0;
            }
        }


        public override void UpTemperature()
        {
            Temperature++;
            //Temperature += 1;
            FanIsOn = "on";
        }
        public override void DownTemperature()
        {
            Temperature -= 1;
        }

        
        public string ValidateTemperature()
        {
            IsWorking();
            if (FanIsOn == "on")
            {
                FanIsOn = "working";
                return $"The Fan is at {Temperature} speed";
            }

            else
            {
                return $"The Fan is not working";
            }
        }


        
        public override string Result()
        {
            
            string isWorking = ValidateTemperature();

            return $"\n{isWorking}, it's {FanIsOn}, and it's color is {RefrigeratorColor}.";

            //if (RefrigeratorColor) // It understands that we are looking for the true value
            //{
            //    return $"{isWorking}, it's {FanIsOn}, and it's color is {refri}.";
            //}
            //else
            //{
            //    return $"{isWorking}, it's {FanIsOn}, and it's color is black.";

        }
    }
}
