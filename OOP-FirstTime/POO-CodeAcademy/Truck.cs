using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CodeAcademy
{
    class Truck : Vehicle, IAutomobile
    {
               
        public double Weight { get; }

        public Truck(double speed, double weight) : base(speed)
        {
            
            Weight = weight;

            if(weight <= 400)
            {
                Wheels = 8;
            } else
            {
                Wheels = 12;
            }

        }
        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.\n";
        }

    }
}
