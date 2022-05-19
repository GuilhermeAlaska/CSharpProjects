using System;

namespace AC_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            AC a = new AC(27, "green");
            Console.WriteLine(a.Result());

            a.UpTemperature(); // It's lowering the temperature 1 degree
            Console.WriteLine(a.Result()); // It's now presenting the AC as off 



            Fan b = new Fan(3, "white");

            Console.WriteLine(b.Result());

            b.UpTemperature();
            Console.WriteLine(b.Result());


            Console.ReadKey();
        }
    }
}
