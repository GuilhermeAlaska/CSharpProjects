using System;

namespace TwoEqualValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, total;
            Console.WriteLine("Welcome, please input the first value:\n");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease input the second value:\n");
            number2 = Convert.ToInt32(Console.ReadLine());

            SumTriple(number1, number2);
        }

        public static int SumTriple(int a, int b)
        {
            Console.WriteLine(a == b ? (a + b) * 3 : a + b);
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}