using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
//Your task is to write a program that extracts emojis from a text and finds the threshold based on the input.
//You have to get your Cool threshold.It is obtained by multiplying all the digits found in the input. The cool threshold could be a
//huge number, so be mindful.
//An emoji is valid when:
//•	It is surrounded by 2 characters, either "::" or "**".
//•	It is at least 3 characters long(without the surrounding symbols).
//•	It starts with a capital letter.
//•	Continues with lowercase letters only.
//Examples of valid emojis: ::Joy::, **Banana**, ::Wink::
//Examples of invalid emojis: ::Joy**, ::fox:es:, **Monk3ys**, :Snak::Es::
//You need to count all valid emojis in the text and calculate their coolness. The coolness of the emoji is determined by summing
//all the ASCII values of all letters in the emoji. 
//Examples: ::Joy:: - 306, **Banana** -577, ::Wink:: - 409
//You need to print the result of the cool threshold and after that – to take all emojis out of the text, count them and print only
//the cool ones on the console.
//Input
//•	On the single input, you will receive a piece of string.
//Output
//•	On the first line of the output, print the obtained Cool threshold in the format:
//"Cool threshold: {coolThresholdSum}"
//•	On the following line, print the count of all emojis found in the text in format:
//"{countOfAllEmojis} emojis found in the text. The cool ones are:
//{ cool emoji 1}
//{ cool emoji 2}
//…
//{ cool emoji N}"
//Constraints
//There will always be at least one digit in the text!
            string pattern = @"(?<digits>\d)|(?<emojies>(\:\:|\*\*)[A-Z][a-z]{2,}\1)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            List<int> digits = new List<int>();
            List<string> emojies = new List<string>();
            foreach (Match item in matches)
            {
                if (int.TryParse(item.Groups["digits"].Value, out int value))
                {
                    digits.Add(value);
                }
                else
                {
                    emojies.Add(item.Groups["emojies"].Value);
                }
            }
            BigInteger coolTreshold = 1;
            foreach (int digit in digits)
            {
                coolTreshold *= digit;
            }
            int mathesFound = emojies.Count;
            emojies = emojies
                .Where(e => SumOfChars(e) >= coolTreshold)
                .ToList();
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{mathesFound} emojis found in the text. \nThe cool ones are:");
            foreach (string emoji in emojies)
            {
                Console.WriteLine(emoji);
            }
        }

        private static ulong SumOfChars(string input)
        {
            char[] separator = new char[] { ':', '*' };
            string[] trimmer = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            input = trimmer[0];
            ulong sumChars = 0;
            foreach (char ch in input)
            {
                sumChars += (ulong)ch;
            }
            return sumChars;
        }
    }
}
