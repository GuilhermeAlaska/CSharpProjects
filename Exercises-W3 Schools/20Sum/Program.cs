using System;

namespace _20Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTwenty(10, 10));
        }

        public static bool IsTwenty(int a, int b)
        {
            bool isTwenty;
            
            if(a + b >= 20 && a + b <= 29)
            {
                isTwenty = true;
                return isTwenty;
            } 
            else
            {
                isTwenty = false;
                return isTwenty;
            }

        }

    }
}
