using System;

namespace FarmAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            int galinhas;
            int vacas;
            int porcos;

            Console.Write("Número de galinhas: ");
            galinhas = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNúmero de vacas: ");
            vacas = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNúmero de porcos: ");
            porcos = Convert.ToInt32(Console.ReadLine());

            int galinhasLegs = (galinhas * 2);
            int vacasLegs = (vacas * 4);
            int porcosLegs = (porcos * 4);

            Console.WriteLine($"\nNúmero de pernas de galinha: {galinhasLegs}.");
            Console.WriteLine($"Número de pernas de vacas: {vacasLegs}.");
            Console.WriteLine($"Número de pernas de porco: {porcosLegs}.");
        }
    }
}
