using System;

namespace AbsoluteDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(result(15, 89));
            Console.WriteLine(result(15, 9));
            Console.WriteLine(result(15, 2));
            Console.WriteLine(result(15, 46));

            Console.ReadKey();
        }

        public static int result(int a, int b)
        {
            if (a > b)
            {
               return (a - b) * 2;
            }
            else
            {
                return (a - b);
            }

           
        }
    }
}
