using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
//Write a program that processes information about a race.On the first line, you will be given a list of participants separated by ", ".On the next few lines, until you
//receive a line "end of the race", you will be given some info which will be some alphanumeric characters. In between them, you could have some extra characters which
//you should ignore. For example: "G!32e%o7r#32g$235@!2e".The letters are the name of the person and the sum of the digits is the distance he ran. So here we have George
//who ran 29 km.Store the information about the person only if the list of racers contains the name of the person.If you receive the same person more than once, just add
//the distance to his old distance. At the end print the top 3 racers in the format:
//"1st place: {first racer}
//2nd place: { second racer}
//3rd place: { third racer}"

            Dictionary<string, int> racers = new Dictionary<string, int>();
            string[] players = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(?<name>[A-Za-z])|(?<digit>[0-9])";
            Regex regex = new Regex(pattern);
            foreach (var personName in players)
            {
                racers.Add(personName, 0);
            }

            string input;

            StringBuilder name = new StringBuilder();
            while ((input = Console.ReadLine()) != "end of race")
            {
                int distance = 0;
                MatchCollection namesAndDigits = regex.Matches(input);

                foreach (Match match in namesAndDigits)
                {
                    if (int.TryParse(match.Groups["digit"].Value, out int currDigit))
                    {
                        distance += currDigit;
                    }
                    else
                    {
                        string currName = match.Groups["name"].Value;
                        name.Append(currName);
                    }
                }
                if (racers.ContainsKey(name.ToString()))
                {
                    racers[name.ToString()] += distance;
                }
                name.Clear();
            }

            racers = racers
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            int i = 1;
            foreach (var racer in racers)
            {
                if (i == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                if (i == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                if (i == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }
                i++;
            }

        }
    }
}
