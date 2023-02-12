//Use your Person class from the previous tasks. Create a class Family. The class should have a
//list of people, a method for adding members - void AddMember(Person member) and a method
//returning the oldest family member – Person GetOldestMember(). Write a program that reads the
//names and ages of N people and adds them to the family. Then print the name and age of the oldest
//member.
using System;

namespace DefiningClasses;

public class StartUp
{
    private static void Main(string[] args)
    {
        Family family = new();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Person person = new(input[0], int.Parse(input[1]));
            family.AddMember(person);
        }

        Person oldestMember = family.GetOldestMember();
        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}
