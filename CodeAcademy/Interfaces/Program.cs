namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan a = new Sedan(60);
            Sedan b = new Sedan(70);
            Truck c = new Truck(45, 500);

            Console.WriteLine($"{a.Speed}, {a.Wheels}, {a.LicensePlate}");
            a.SpeedUp();
            Console.WriteLine($"{a.Speed}.");

            Console.WriteLine($"{b.Speed}, {b.Wheels}, {b.LicensePlate}");
            b.SpeedUp();
            Console.WriteLine($"{b.Speed}.");

            Console.WriteLine($"{c.Speed}, {c.Wheels}, {c.LicensePlate}");
            c.SpeedUp();
            Console.WriteLine($"{c.Speed}.");

        }

















    }
}