class Program
{
    static void Main(string[] args)
    {
        string designer = "Anders Hejlsberg";
        int indexOfSpace = designer.IndexOf(" ");
        string secondName = designer.Substring(indexOfSpace);
        Console.WriteLine(secondName);

        // Calling a method from outside, giving it parameters
        VisitPlanets(3);
        VisitPlanets(100);
        VisitPlanets(49182);

        /* Calling 3 Different methods giving 3 different instances
         
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }
    
    static void NamePets(string pet1, string pet2){

    Console.WriteLine ($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
    }
    
    static void NamePets (string pet3, string pet4, string pet5){
    
    Console.WriteLine ($"Your pets {pet3}, {pet4} and {pet5} will be joining your voyage across space!");
    }
    
        static void NamePets(){
    Console.WriteLine("Aw, you have no spacefaring pets :(");
    }*/

/*
 static void Main(string[] args)
{
NamePets("Tom", "Pudge");

VisitPlanets(numberOfPlanets: 71326);
}

static void NamePets()
{
Console.WriteLine("Aw, you have no spacefaring pets :(");
}

static void NamePets(string pet1, string pet2)
{
Console.WriteLine($"Your pets {pet1} and {pet2} will be joining your voyage across space!");
}  

static void NamePets(string pet1, string pet2, string pet3)
{
Console.WriteLine($"Your pets {pet1}, {pet2}, and {pet3} will be joining your voyage across space!");
}  

static void VisitPlanets(
string adjective = "brave",
string name = "Cosmonaut", 
int numberOfPlanets = 0,
double gForce = 4.2)
{



Console.WriteLine($"Welcome back, {adjective} {name}.");
Console.WriteLine($"You visited {numberOfPlanets} new planets...");
Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
}*/















Console.ReadKey();
}
static void VisitPlanets(int numberOfPlanets)
{
Console.WriteLine($"You visited {numberOfPlanets} new planets...");


}
}