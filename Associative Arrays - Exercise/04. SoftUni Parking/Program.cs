using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
//SoftUni just got a new parking lot.It's so fancy, it even has online parking validation. Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it. Good thing you're on the dev team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to leave.
//The program receives 2 commands:	
//•	"register {username} {licensePlateNumber}":
//o   The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
//"{username} registered {licensePlateNumber} successfully"
//•	"unregister {username}":
//o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"
//After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
//•	"{username} => {licensePlateNumber}"
//Input
//•	First line: n - number of commands – integer.
//•	Next n lines: commands in one of the two possible formats:
//o Register: "register {username} {licensePlateNumber}"
//o Unregister: "unregister {username}"
//The input will always be valid and you do not need to check it explicitly.
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string key = input[1];
                string value = string.Empty;

                if (command == "register")
                {
                    value = input[2];
                    if (!users.ContainsKey(key))
                    {
                        users.Add(key, value);
                        Console.WriteLine($"{key} registered {value} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[key]}");
                    }

                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(key))
                    {
                        Console.WriteLine($"ERROR: user {key} not found");
                    }
                    else
                    {
                        users.Remove(key);
                        Console.WriteLine($"{key} unregistered successfully");
                    }
                }

            }

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
