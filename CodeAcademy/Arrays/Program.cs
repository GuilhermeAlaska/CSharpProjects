class Program
{
    static void Main(string[] args)
    {
        string[] summerStrut;

        summerStrut = new string[] {
      "Bullet for my Valentine - A Place Where You Belong",
      "BC Raff - VVS",
      "Billie Eilish - Your Power",
      "Nick Cave - Abattoir Blues",
      "Duzz - Patricia",
      "Nelly Furtado - Say it Right",
      "Major RD - 60K",
      "Lil Peep - Haunt u"};

        int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

        //string[] summerStrut;

        //summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Despacito", "Los Angeles", "Chatuba de Mesquita" };

        if (summerStrut.Length == 8)
        {
            Console.WriteLine("summerStrut Playlist is ready to go!\n");
        }
        else if (summerStrut.Length > 8)
        {
            Console.WriteLine("Too many songs!");
        }
        else if (summerStrut.Length < 8)
        {
            Console.WriteLine("Add some songs!");
        }

        Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

        summerStrut[7] = "Lil Peep - The Brightside";



        int stars3 = Array.IndexOf(ratings, 3);
        int thirdSong = Array.IndexOf(summerStrut, "New York Groove");
        string tenChar = Array.Find(summerStrut, name => name.Length >= 10);

        Array.Sort(summerStrut);
        string aSong = summerStrut[0];
        string zSong = summerStrut[7];

        Console.WriteLine($"Song number {thirdSong + 1} is rated {stars3} stars.");
        Console.WriteLine($"The first song that has more than 10 characters in the title is {tenChar}.");
        Console.WriteLine($"First Song is {aSong} and last is {zSong}.");



        string[] summerCopy = new string[8];
        Array.Copy(summerStrut, summerCopy, 8); // It's copying the values of another array
        Array.Reverse(summerCopy);  // It's turning the values backwards
        Array.Clear(ratings, 0, ratings.Length); // It's deleting all values

        Console.WriteLine($"{ratings[0]}, {summerCopy[0]}");







        Console.ReadLine();
    }
}