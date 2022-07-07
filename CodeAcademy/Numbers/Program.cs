// See https://aka.ms/new-console-template for more information


namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employee
            int totalEmployees = 86928;

            // Revenue
            decimal revenue = 390819.28m;

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);



            // Your Age
            int userAge = 20;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(newJupiterAge);
            Console.WriteLine(newEarthAge);


            // Two steps forward, one step back
            // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps);


            // How many eggs can I fit in crates of 12?
            int eggs = 56;
            int crateAmount = 12;

            int eggsLeftOver = eggs % crateAmount;
            Console.WriteLine(eggsLeftOver); // prints 8

            // To know if a number is even or odd
            int myNum = 85939824;
            Console.WriteLine(myNum % 2); // prints 0, so number is even

            //Math.Abs(-5);
            //Math.Sqrt(16);
            //Math.Floor(8.51);
            //Math.Min(39, 12);

            // Starting variables 
            //int numberOne = 12932;
            //int numberTwo = -2828472;

            // Use built-in methods and save to variable 

            //double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));
            // Use built-in methods and save to variable 
            //double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            //Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));



            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));






            Console.ReadKey();
        }
    }
}













    


