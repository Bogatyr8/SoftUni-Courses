//NOTE: You need a StartUp class with the namespace DefiningClasses.
//Add 3 constructors to the Person class from the last task. Use constructor chaining to reuse code:
//The first should take no arguments and produce a person with the name "No name" and age = 1. 
//The second should accept only an integer number for the age and produce a person with the name
//"No name" and age equal to the passed parameter.
//The third one should accept a string for the name and an integer for the age and should produce
//a person with the given name and age.
using System;
namespace DefiningClasses;
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

        Person noNameAndDefaultAge = new();
        Person noNameAge= new(25);
        Person john = new("John", 15);

        Console.WriteLine($"{peter.Name} is {peter.Age} years old");
        Console.WriteLine($"{george.Name} is {george.Age} years old");

        Console.WriteLine($"{noNameAndDefaultAge.Name} is {noNameAndDefaultAge.Age} years old");
        Console.WriteLine($"{noNameAge.Name} is {noNameAge.Age} years old");
        Console.WriteLine($"{john.Name} is {john.Age} years old");
    }
}