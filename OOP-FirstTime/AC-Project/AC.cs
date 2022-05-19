using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Project
{
    class AC : Refrigerator
    {
        public AC(double temperature, string refrigeratorColor) : base(temperature, refrigeratorColor)
        {

        }

        public override string IsWorking()
        {
            if (Temperature >= 27)
            {
                Temperature = 27;
                return Temperature.ToString();
                

            }
            else if (Temperature <= 14 && Temperature >= 11)
            {
                Temperature = 14;
                FanIsOn = "on";
            }
            else
            {
                FanIsOn = "off";
            }
        }

        public override void UpTemperature()
        {
            Temperature += 1;
            FanIsOn = "on";
        }
        public override void DownTemperature()
        {
            Temperature -= 1;
        }




        public string ValidateTemperature()
        {
            IsWorking();
            if (Temperature >= 14 && Temperature <= 27)
            {
                FanIsOn = "on";
                return $"The AC is at {Temperature}º,";
            }

            else
            {
                FanIsOn = "off";
                return $"The AC is not working,";
            }
        }

        public override string Result()
        {

            string isWorking = ValidateTemperature();

            return $"\n{isWorking} it's {FanIsOn}, and it's color is {RefrigeratorColor}.";


            //if (RefrigeratorColor)
            //{
            //    return $"{isWorking} it's {FanIsOn}, and it's color is white.";
            //}
            //else
            //{
            //    return $"{isWorking} it's {FanIsOn}, and it's color is black.";
            //}
        }
    }
}
