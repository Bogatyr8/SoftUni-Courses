﻿//It’s the future, you’re the ruler of a totalitarian dystopian society
//inhabited by citizens and robots, since you’re afraid of rebellions you
//decide to implement strict control of who enters your city. Your
//soldiers check the Ids of everyone who enters and leaves.
//You will receive an unknown amount of lines from the console until the
//command "End" is received, on each line, there will be a piece of
//information for either a citizen or a robot who tries to enter your
//city in the format: "{name} {age} {id}" for citizens and
//"{model} {id}" for robots.After the "End" command on the next
//line, you will receive a single number representing the last digits of
//fake ids, all citizens or robots whose Id ends with the specified
//digits must be detained.
//The output of your program should consist of all detained Ids each on
//a separate line in the order of input.
//Input
//The input comes from the console.Every commands’ parameters before the
//command "End" will be separated by a single space.

using BorderControl;
using System;
using System.Collections.Generic;
using System.Linq;

List<IInhabitant> inhabitants = new List<IInhabitant>();

string inputLine;
while ((inputLine = Console.ReadLine()) != "End")
{
    string[] inhabitantData = inputLine
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    if (inhabitantData.Length == 3)
    {
        IInhabitant citizen = new Citizen(inhabitantData[0], int.Parse(inhabitantData[1]), inhabitantData[2]);
        inhabitants.Add(citizen);
    }
    else if (inhabitantData.Length == 2)
    {
        IInhabitant robot = new Robot(inhabitantData[0],  inhabitantData[1]);
        inhabitants.Add(robot);
    }
}

string fakeIdChecker = Console.ReadLine();

List<IInhabitant> fakeIdS = inhabitants
    .Where(p => p.Id.EndsWith(fakeIdChecker))
    .ToList();


Console.WriteLine(String.Join(Environment.NewLine, fakeIdS));