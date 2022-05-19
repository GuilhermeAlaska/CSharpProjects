using System;

namespace POO_CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());

            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());

            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());


            //Console.WriteLine($"The first Sedan has the speed of {a.Speed}, has {a.Wheels} wheels and it's license plate is {a.LicensePlate}.\n");

            //Console.WriteLine($"The second Sedan has the speed of {b.Speed}, has {b.Wheels} wheels and it's license plate is {b.LicensePlate}.\n");

            //Console.WriteLine($"The first Truck has the speed of {c.Speed}, has {c.Wheels} wheels and it's license plate is {c.LicensePlate}.\n");

            s.SpeedUp();
            b.SpeedUp();
            t.SpeedUp();

            Console.WriteLine($"Sedan s has now the speed of {s.Speed} km/h.\n");
            Console.WriteLine($"Bicycle b has now the speed of {b.Speed} km/h.\n");
            Console.WriteLine($"Truck t has now the speed of {t.Speed} km/h.\n");
        }
    }

}