using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnInheritance
{
    class Bicycle : Vehicle
    {

        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }
        public override string Describe()
        {
            return Console.WriteLine("This bicycle is moving on 2 wheels at 10 km/h, with license plate ABCD1234.");
        }

    }
}