

class Program
{
    static void Main(string[] args)
    {
        // First string variable
        string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
        // Second string variable
        string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

        // Print variable and newline
        Console.WriteLine(firstSentence);
        Console.WriteLine("\n");
        Console.WriteLine(firstSpeech);
        Console.WriteLine("\n");

        // Declare the variables
        string beginning = "Once upon a time,";
        string middle = "a frog called Tom";
        string end = ".. jumped from a cliff and died.";
        // Concatenate the string and the variables
        string story = beginning + " " + middle + "." + end;

        // Print the story to the console 
        Console.WriteLine(story);
        Console.WriteLine("\n");

        // Create password
        string password = "a92301j2add";

        // Get password length
        int passwordLength = password.Length;

        // Check if password uses symbol
        //Console.WriteLine(passwordLength);
        int passwordCheck = password.IndexOf("!");
        // Print results
        Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");



        // User Name
        string name = "Farhad Hesam Abbasi";

        // Get first letter
        int charPosition = name.IndexOf("F");
        char firstLetter = name[charPosition];

        // Get last name
        int lastNamePosition = name.IndexOf("Abbasi");
        string lastName = name.Substring(lastNamePosition);
        // Print results
        Console.WriteLine(lastName);


        // Out Method
        string ageAsString = "102";
        string nameAsString = "Granny";
        int ageAsInt;
        //bool outcome;

        //outcome = Int32.TryParse(ageAsString, out ageAsInt); // This method is making a string into a int
        //Console.WriteLine($"{outcome}, {ageAsInt}");


        string destination = "Neptune";
        string galaxyString = "8";
        int galaxyInt;
        string welcomeMessage;
        bool outcome;

        // Call DecoratePlanet() and TryParse() here
        welcomeMessage = DecoratePlanet(destination);
        outcome = Int32.TryParse(galaxyString, out galaxyInt);
        // Print results
        Console.WriteLine(welcomeMessage);
        Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");


        // Fat Arrow method
    //    Welcome("Earth");
    //    double days = 500;
    //    double rotations = DaysToRotations(days);
    //    Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    //}
    //static double DaysToRotations(double days) => days / 365;

    //static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");









    Console.ReadKey();
    }
    
    // Define a method that returns a string
    static string DecoratePlanet(string planet)
    {
        return $"*..*..* Welcome to {planet} *..*..*";
    }

    
    // Define a method with out
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
        wasWhisperCalled = true;
        return phrase.ToLower();
    }
}

