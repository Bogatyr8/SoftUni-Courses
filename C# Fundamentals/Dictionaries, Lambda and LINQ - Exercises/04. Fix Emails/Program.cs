using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
//You are given a sequence of strings, each on a new line, until you receive the “stop” command.The first string is the name of a
//person.On the second line, you will receive their email. Your task is to collect their names and emails, and remove emails whose
//domain ends with "us" or "uk"(case insensitive).Print:
//{ name} – > { email}
            Dictionary<string, string> users = new Dictionary<string, string>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "stop")
            {
                string inputEmail = Console.ReadLine();
                users[inputString] = inputEmail;
            }

            users = users
                .Where(u => u.Value.Split(".").ToArray()[u.Value.Split(".").ToArray().Length - 1] != "us")
                .Where(u => u.Value.Split(".").ToArray()[u.Value.Split(".").ToArray().Length - 1] != "uk")
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var (x, y) in users)
            {
                Console.WriteLine($"{x} -> {y}");
            }
        }
    }
}
