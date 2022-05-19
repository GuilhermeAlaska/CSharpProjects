using System;

namespace MinutesToSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos minutos: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int seconds = (minutes * 60);

            Console.WriteLine($"{minutes} minutos em segundos são {seconds} segundos.");
        }
    }
}
