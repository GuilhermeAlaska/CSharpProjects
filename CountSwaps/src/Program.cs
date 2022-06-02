using System;

namespace CountSwaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 5, 4, 9, 2, 1, 6 };
            Console.WriteLine("Minimum swaps: " + Swap.GetMinimumSwaps(array));
        }
    }
}