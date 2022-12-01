using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add functionality to the phonebook from the previous task to print all contacts ordered lexicographically when receive the
            //command “ListAll”.
            SortedDictionary<string, string> users = new SortedDictionary<string, string>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "END")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                if (command == "A")
                {
                    string name = input[1];
                    string phone = input[2];
                    users[name] = phone;
                }
                else if (command == "S")
                {
                    string name = input[1];
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {users[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var item in users)
                    {
                        Console.WriteLine($"{item.Key}<->{item.Value}");
                    }
                }
            }
        }
    }
}