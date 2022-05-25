using System;

namespace HoursIntoSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert any hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int hoursInSeconds = ((hours * 60) * 60);

            Console.WriteLine($"{hours} hours are {hoursInSeconds} seconds.");
        }
    }
}
