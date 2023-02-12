//Using the Person class, write a program that reads from the console N lines of personal
//information and then prints all people, whose age is more than 30 years, sorted in
//alphabetical order.

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
            string name = input[0];
            int age = int.Parse(input[1]);

            Person person = new(name, age);
            family.AddMember(person);
        }

        family.PrintMembers();
    }
}