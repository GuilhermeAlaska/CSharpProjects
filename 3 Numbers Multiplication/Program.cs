using System;

namespace _3_Numbers_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, total;
            Console.WriteLine("Welcome, input your first number of the multiplication\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your second number of the multiplication\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your third number of the multiplication\n");
            number3 = Convert.ToInt32(Console.ReadLine());

            total = (number1 * number2) * number3;

            Console.WriteLine($"The result of the multiplication of {number1} * {number2} * {number3} is equal to = {total}.");
        }
    }
}
