


namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forest f = new Forest();
            //f.name = "Amazonia";
            //f.trees = 96525;
            //f.age = 7000;
            //f.biome = "Equatorial";

            //Console.WriteLine(f.name);
            Forest f = new Forest("Rendlesham");

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            Forest.PrintTreeFacts();

            f.Grow();

            Console.WriteLine(Forest.TreeFacts);

        }
    }
}