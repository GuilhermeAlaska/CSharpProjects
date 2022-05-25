using System;

namespace Media_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, average;

            Console.WriteLine("\nInput the first number:\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the second number:\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the third number:\n");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput the fourth number:\n");
            number4 = Convert.ToInt32(Console.ReadLine());

            average = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ", number1, number2, number3, number4, average);
        }
    }
}
