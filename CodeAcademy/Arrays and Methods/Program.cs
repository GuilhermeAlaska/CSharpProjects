
class Program
{
    // Method to be used as second argument
    public static bool IsLong(string word)
    {
        return word.Length > 8;
    }

    static void Main(string[] args)
    {
        // Array to be used as first argument
        string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

        // Call Array.Find() and 

        // Pass in the array and method as arguments
        string firstLongAdjective = Array.Find(adjectives,IsLong);

        Console.WriteLine($"The first long word is: {firstLongAdjective}.");




        string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

        bool makesContact = Array.Exists(spaceRocks, (string rock) => rock == "meteorite");
        //bool makesContact = Array.Exists(spaceRocks, rock => rock == "meteorite")  Lambda expressions can be resumed, because the comparing can only be made with two of the same type

        if (makesContact)
        {
            Console.WriteLine("At least one space rock has reached the Earth's surface!");
        }





        int[] nums = { 0, 555, 252, 3, 9, 101, 56 };

        bool hasBigNum = Array.Exists(nums, isBig => isBig > 100);

        bool hasSmallNum = Array.Exists(nums, isSmall => isSmall < 10);

        bool hasMediumNum = Array.Exists(nums, n => n >= 10 && n <= 100);

        Console.WriteLine($"Any big #s? {hasBigNum}");
        Console.WriteLine($"Any small #s? {hasSmallNum}");
        Console.WriteLine($"Any medium #s? {hasMediumNum}");












        Console.ReadKey();
    }





















}
