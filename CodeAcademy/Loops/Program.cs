
class Program
{
    static void Main(string[] args) {


        int emails = 20;

        while (emails > 0)
        {
            emails--;
        }

        Console.WriteLine("INBOX ZERO ACHIEVED!");


        // Only run once or infinity
        bool buttonClick = false; // Do not false
        int times = 0;


        do
        {
            Console.WriteLine("BLARRRRRRRRR");
            times++;
            if (times == 3)
            {
                break;
            }
        }
        while (!buttonClick);

        Console.WriteLine("Time for a five minute break");


        for (int i = 1; i < 17; i++)
        {
            Console.WriteLine(i);

        }

        // ForEach Loop
        //string[] melody = { "a", "b", "c", "c", "b" };
        //foreach (string note in melody)
        //{
        //    PlayMusic(note);
        //}



        //        while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
        //        do ...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
        //        for loops are best if you want something to run a specific number of times, rather than given a certain condition.
        //        foreach loops are the best way to loop over an array, or any other collection.








        Console.ReadKey();
    }
}
