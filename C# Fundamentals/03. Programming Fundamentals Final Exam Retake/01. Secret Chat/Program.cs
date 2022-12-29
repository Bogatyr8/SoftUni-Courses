using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
//You have plenty of free time, so you decide to write a program that conceals and reveals your received messages.Go ahead and
//type it in!
//On the first line of the input, you will receive the concealed message.After that, until the "Reveal" command is given, you will
//receive strings with instructions for different operations that need to be performed upon the concealed message to interpret it
//and reveal its actual content.There are several types of instructions, split by ":|:"
//•	"InsertSpace:|:{index}":
//o  Inserts a single space at the given index.The given index will always be valid.
//•	"Reverse:|:{substring}":
//o If the message contains the given substring, cut it out, reverse it and add it at the end of the message.
//o If not, print "error".
//o This operation should replace only the first occurrence of the given substring if there are two or more occurrences.
//•	"ChangeAll:|:{substring}:|:{replacement}":
//o Changes all occurrences of the given substring with the replacement text.
//Input / Constraints
//•	On the first line, you will receive a string with a message.
//•	On the following lines, you will be receiving commands, split by ":|:".
//Output
//•	After each set of instructions, print the resulting string.
//•	After the "Reveal" command is received, print this message:
//"You have a new text message: {message}"
            string concealedText = Console.ReadLine();
            string commantText;

            while ((commantText = Console.ReadLine()) != "Reveal")
            {
                string[] commArg = commantText
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = commArg[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(commArg[1]);
                    concealedText = concealedText.Insert(index, " ");
                    Console.WriteLine(concealedText);
                }
                else if (command == "Reverse")
                {
                    string subString = commArg[1];
                    if (concealedText.Contains(subString))
                    {
                        int index = concealedText.IndexOf(subString);
                        concealedText = concealedText.Remove(index, subString.Length);
                        subString = Reverse(subString);
                        concealedText = concealedText + subString;
                        Console.WriteLine(concealedText);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string subString = commArg[1];
                    string replacement = commArg[2];
                    concealedText = concealedText.Replace(subString, replacement);
                    Console.WriteLine(concealedText);
                }
            }
            Console.WriteLine($"You have a new text message: {concealedText}");
        }

        static string Reverse(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            input = new string(arr);
            return input;
        }
    }
}
