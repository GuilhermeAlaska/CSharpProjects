using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CodeAcademy
{
    abstract class Vehicle
    {
        public string LicensePlate { get; private set;} // Implementing Methods
        public virtual int Wheels { get; protected set;}
        public virtual double Speed { get; protected set;}

        public void Honk()
        {
            Console.WriteLine("~Honking");
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }
        public virtual void SlowDown() // Virtual is used to be overrided if you need to in other subclasses
        {
            Speed -= 5;
        }

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
        }

        public abstract string Describe(); // To use abstract methods, the class itself must be abstract | Polymorphism
    }
}
