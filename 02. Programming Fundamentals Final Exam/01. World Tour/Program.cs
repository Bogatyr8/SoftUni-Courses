using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
//You are a world traveler, and your next goal is to make a world tour.To do that, you have to plan out everything first. To start
//with, you would like to plan out all of your stops where you will have a break.
//On the first line, you will be given a string containing all of your stops. Until you receive the command "Travel", you will be
//given some commands to manipulate that initial string.The commands can be:
//•	"Add Stop:{index}:{string}":
//o Insert the given string at that index only if the index is valid
//•	"Remove Stop:{start_index}:{end_index}":
//o Remove the elements of the string from the starting index to the end index(inclusive) if both indices are valid
//•	"Switch:{old_string}:{new_string}":
//o If the old string is in the initial string, replace it with the new one(all occurrences)
//Note: After each command, print the current state of the string if it is valid!
//After the "Travel" command, print the following: "Ready for world tour! Planned stops: {string}"
//Input / Constraints
//•	JavaScript: you will receive a list of strings
//•	An index is valid if it is between the first and the last element index(inclusive) (0 …..Nth) in the sequence.
//Output
//•	Print the proper output messages in the proper cases as described in the problem description
            string input = Console.ReadLine();

            string commArg;
            while ((commArg = Console.ReadLine()) != "Travel")
            {
                string[] commandInput = commArg
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInput[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(commandInput[1]);
                    string newStop = commandInput[2];
                    if (CheckIndexValidity(input, index))
                    {
                        input = input.Insert(index, newStop);
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(commandInput[1]);
                    int endIndex = int.Parse(commandInput[2]);
                    if (CheckIndexValidity(input, startIndex) && CheckIndexValidity(input, endIndex))
                    {
                        int wordLength = endIndex - startIndex + 1;
                        input = input.Remove(startIndex, wordLength);
                        Console.WriteLine(input);
                    }
                }
                else if (command == "Switch")
                {
                    string oldStop = commandInput[1];
                    string newStop = commandInput[2];
                    while (input.Contains(oldStop))
                    {
                        input = input.Replace(oldStop, newStop);
                        Console.WriteLine(input);
                    }
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }

        private static bool CheckIndexValidity(string input, int index)
        {
            return  0 <= index && index <= (input.Length - 1);
        }
    }
}
