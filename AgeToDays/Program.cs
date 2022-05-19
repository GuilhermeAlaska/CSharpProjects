using System;

namespace AgeToDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int ageInDays = (age * 365);
            Console.WriteLine($"{age} years in days is {ageInDays}.");

        }
    }
}
