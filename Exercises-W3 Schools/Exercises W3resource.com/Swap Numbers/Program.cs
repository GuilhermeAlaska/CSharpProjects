using System;

namespace Exercises_W3resource
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.WriteLine("Input your first number:\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your second number:\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"The first number was {number1} and the second one {number2}.");

        }
    }
}
