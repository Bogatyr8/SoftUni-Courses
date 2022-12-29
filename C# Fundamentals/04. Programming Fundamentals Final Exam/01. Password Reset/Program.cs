using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
//Yet again, you have forgotten your password. Naturally, it's not the first time this has happened. Actually, you got so tired of
//it that you decided to help yourself with an intelligent solution.
//Write a password reset program that performs a series of commands upon a predefined string.First, you will receive a string, and
//afterward, until the command "Done" is given, you will be receiving strings with commands split by a single space. The commands
//will be the following:
//•	"TakeOdd"
//o Takes only the characters at odd indices and concatenates them to obtain the new raw password and then prints it.
//•	"Cut {index} {length}"
//o Gets the substring with the given length starting from the given index from the password and removes its first occurrence, then
//prints the password on the console.
//o The given index and the length will always be valid.
//•	"Substitute {substring} {substitute}"
//o If the raw password contains the given substring, replaces all of its occurrences with the substitute text given and prints the
//result.
//o If it doesn't, prints "Nothing to replace!".
//Input
//•	You will be receiving strings until the "Done" command is given.
//Output
//•	After the "Done" command is received, print:
//o "Your password is: {password}"
//Constraints
//•	The indexes from the "Cut {index} {length}" command will always be valid.
            string rawPassword = Console.ReadLine();
            string inputString;
            
            while ((inputString = Console.ReadLine()) != "Done")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                if (command == "TakeOdd")
                {
                    rawPassword = TakeOdd(rawPassword);
                    Console.WriteLine(rawPassword);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(input[1]);
                    int length = int.Parse(input[2]);
                    rawPassword = rawPassword.Remove(index, length);
                    Console.WriteLine(rawPassword);
                }
                else if (command == "Substitute")
                {
                    string substring = input[1];
                    string substitute = input[2];
                    if (rawPassword.Contains(substring))
                    {
                        rawPassword = rawPassword.Replace(substring, substitute);
                        Console.WriteLine(rawPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {rawPassword}");
        }

        static string TakeOdd(string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sb.Append(input[i]);
                }
            }
            return sb.ToString();
        }
    }
}
