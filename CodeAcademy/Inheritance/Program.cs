namespace LearnInheritance
{
    class Program
    {
        static public Main(string[] args)
        {
            Sedan s = new Sedan(60);

            Truck t = new Truck(45, 500);

            Bicycle b = new Bicycle(10);

            s.Describe();
            t.Describe();
            b.Describe();
        }
    }
}