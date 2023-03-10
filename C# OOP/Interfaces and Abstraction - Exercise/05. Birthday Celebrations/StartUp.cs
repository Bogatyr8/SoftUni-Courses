//It is a well - known fact that people celebrate birthdays, it is also
//known that some people also celebrate their pets’ birthdays. Extend
//the program from your last task to add birthdates to citizens and
//include a class Pet, pets have a name and a birthdate. Encompass
//repeated functionality into interfaces and implement them in your
//classes. 
//You will receive from the console an unknown number of lines. Until
//the command "End" is received, each line will contain information in
//one of the following formats "Citizen <name> <age> <id> <birthdate>"
//for Citizen, "Robot <model> <id>" for Robot or
//"Pet <name> <birthdate>" for Pet. After the "End" command on the next
//line, you will receive a single number representing a specific year,
//your task is to print all birthdates (of both Citizen and Pet) in that
//year in the format day/month/year in the order of input.

using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Linq;

List<IBornable> living = new List<IBornable>();
List<IInhabitant> inhabitant = new List<IInhabitant>();

string inputLine;
while ((inputLine = Console.ReadLine()) != "End")
{
    string[] inhabitantData = inputLine
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (inhabitantData[0] == "Citizen")
    {
        IBornable citizen = new Citizen(inhabitantData[1], int.Parse(inhabitantData[2]), inhabitantData[3], inhabitantData[4]);
        living.Add(citizen);
    }
    else if (inhabitantData[0] == "Pet")
    {
        IBornable pet = new Pet(inhabitantData[1], inhabitantData[2]);
        living.Add(pet);
    }
    else if (inhabitantData[0] == "Robot")
    {
        IInhabitant robot = new Robot(inhabitantData[1], inhabitantData[2]);
        inhabitant.Add(robot);
    }
}

string checkYear = Console.ReadLine();

List<IBornable> annoCheck = living
    .Where(p => p.Birthday.EndsWith(checkYear))
    .ToList();


Console.WriteLine(String.Join(Environment.NewLine, annoCheck));