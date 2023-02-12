//Create a class DateModifier, which stores the difference of the days between two dates.
//It should have a method that takes two string parameters, representing dates as strings and
//calculates the difference in the days between them. 
using System;
namespace Date_Modifier;

public class StartUp
{
    public static void Main(string[] args)
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();

        int differenceInDays = DateModifier.DateDifference(start, end);

        Console.WriteLine(differenceInDays);
    }
}