using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get; }

        public override string Describe()
        {
            return Console.WriteLine($"dsaasd");
        }


        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

    }
}