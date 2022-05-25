using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, kelvin, celsius;
            Console.WriteLine("Input your actual temperature: \n");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1- Celsius\n2- Fahrenheit\n3- Kelvin\nWich one did you input?\n");
            int entry = Convert.ToInt32(Console.ReadLine());

            if (entry == 1)
            {
                celsius = temperature;
                fahrenheit = (celsius * 9 / 5) + 32;
                kelvin = celsius + 273.15;

                Console.WriteLine($"\n{temperature}° in fahrenheit is {fahrenheit}° and in Kelvin is {kelvin}°.");
            }

            else if (entry == 2)
            {
                fahrenheit = temperature;
                celsius = (fahrenheit - 32) * 5 / 9;
                kelvin = ((fahrenheit - 32) * 5 / 9) + 273.15;

                Console.WriteLine($"\n{temperature}° in celsius is {celsius}° and in Kelvin is {kelvin}°.");
            }
            else if (entry == 3)
            {
                kelvin = temperature;
                celsius = kelvin - 273.15;
                fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;

                Console.WriteLine($"\n{temperature}° in celsius is {celsius}° and in Kelvin is {fahrenheit}°.");
            }
            else
            {
                Console.WriteLine("Please enter a valid entry and try again.");
            }



            Console.ReadKey();
        }
    }

}
