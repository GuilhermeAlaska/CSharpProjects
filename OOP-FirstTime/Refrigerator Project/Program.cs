using System;

namespace Refrigerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AirConditioner(14, "black");
            a.LowerTemperature();
            Console.WriteLine(a.Result());


            AirConditioner b = new(26, "white");
            b.HigherTemperature();
            Console.WriteLine(b.Result());

            Fan c = new Fan(3, "black");
            Console.WriteLine(c.Result());

            c.HigherTemperature(); // Makes it go 0
            c.HigherTemperature(); // Starts it again
            Console.WriteLine(c.Result());


            var f = new Fan(2, "red");
            f.LowerTemperature();
            f.LowerTemperature();
            Console.WriteLine(f.Result());

        }
    }
}
