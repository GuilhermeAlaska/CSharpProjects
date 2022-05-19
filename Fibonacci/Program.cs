using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f = new();
            f.CreateFibonacciSequence(30);
        }
    }
}