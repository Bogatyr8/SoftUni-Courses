using System;
using System.Collections.Generic;

namespace _01._Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives some info from the console about people and their phone numbers. Each entry should have just one name and one number(both of them strings). 
            //On each line, you will receive some of the following commands:
            //•	A {name} {phone} – adds entry to the phonebook.In case of trying to add a name that is already in the phonebook you should change the existing phone number with the new one provided.
            //•	S {name} – searches for a contact by given name and prints it in format "{name} -> {number}".In case the contact isn't found, print "Contact {name} does not exist.".
            //•	END – stop receiving more commands.
            Dictionary<string, string> users = new Dictionary<string, string>();
            string inputString;
            while ((inputString = Console.ReadLine()) != "END")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string name = input[1];
                if (command == "A")
                {
                    string phone = input[2];
                    users[name] = phone;
                }
                else if (command == "S")
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {users[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
