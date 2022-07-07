
class Program
{
    static void Main(string[] args)
    {
        double timeToDinner = 4.00;
        double distance = 95;
        double rate = 30;

        double tripDuration = distance / rate;

        bool answer = tripDuration <= timeToDinner;
        Console.WriteLine(answer);


        bool beach = true;
        bool hiking = false;
        bool city = true;
        bool yourNeeds = beach && city;
        bool friendNeeds = beach || hiking;

        bool tripDecision = friendNeeds && yourNeeds;

        Console.WriteLine(tripDecision);


        int socks = 6;

        if (socks <= 3)
        {
            Console.WriteLine("Time to do laundry!");
        }
        else
        {
            Console.WriteLine("You're fine.");
        }

        string weather = "rain";
        if (weather == "nice")
        {
            Console.WriteLine("Let's go out, it's a beautiful day!");
        }
        else
        {
            Console.WriteLine("It's better for us to stay at home.");
        }
            int guests = 0;
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            else if (guests >= 1)
            {
                Console.WriteLine("Innovation");
            }
            else
            {
                Console.WriteLine("Solitaire");
            }

                Console.WriteLine("Pick a Genre: Drama, Comedy, Adventure, Horror or Science Fiction.");
                string genre = Console.ReadLine();


                switch (genre)
                {
                    case "Drama":
                        Console.WriteLine("Citizen Kane");
                        break;
                    case "Comedy":
                        Console.WriteLine("Duck Soup");
                        break;
                    case "Adventure":
                        Console.WriteLine("King Kong");
                        break;
                    case "Horror":
                        Console.WriteLine("Psycho");
                        break;
                    case "Science Fiction":
                        Console.WriteLine("2001: A Space Odyssey");
                        break;
                    default:
                        Console.WriteLine("No movie found");
                        break;
                }

                     int pepperLength = 4;
                     string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

                     Console.WriteLine(message);


        // Movie Indicator 1.0
        Console.WriteLine("Welcome to Movie Indicator 1.0! \nPick your favorite gender:\n");

        Console.WriteLine("Horror\nDrama\nComedy\nRomance\nSuperHero\nScience Fiction\nMindBlowing");
        string genderChoice = Console.ReadLine().ToUpper();

        switch (genderChoice)
        {
            case "HORROR":
                Console.WriteLine("You should watch: Hereditary");
                break;
            case "DRAMA":
                Console.WriteLine("You should watch: Schindler's List");
                break;
            case "COMEDY":
                Console.WriteLine("You should watch: O auto da Compadecida");
                break;
            case "ROMANCE":
                Console.WriteLine("You should watch: To all the boys I loved");
                break;
            case "SUPERHERO":
                Console.WriteLine("You should watch: The Dark Knight");
                break;
            case "MINDBLOWING":
                Console.WriteLine("You should watch: Predestination");
                break;
            default:
                Console.WriteLine("Make sure to write the gender correctly and try again.");
                break;
        }

        int personAge = 20;
        int dogFirstYear = 15;
        int dogSecondYear = 9;
        int dogMoreYears = 5;
        int personAgeInDogYears = ((personAge - 2) * dogMoreYears) + dogFirstYear + dogSecondYear;


        Console.WriteLine(personAgeInDogYears);









        Console.ReadKey();

    }
}

