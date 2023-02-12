//NOTE: You need a StartUp class with the namespace DefiningClasses.
//Define a class Person with private fields for name and age and public properties Name and Age.
//Bonus*
//Try to create a few objects of type Person:
//NOTE: Use both the inline initialization and the default constructor.
using DefiningClasses;
public class StartUp
{
    public static void Main(string[] args)
    {
        Person peter = new();
        peter.Name = "Peter";
        peter.Age = 20;

        Person george = new()
        {
            Name = "George",
            Age = 18
        };

        Console.WriteLine($"{peter.Name} is {peter.Age} years old");
        Console.WriteLine($"{george.Name} is {george.Age} years old");
    }
}
