using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that counts all characters in a string, except for space(' ').
            //Print all the occurrences in the following format:
            //"{char} -> {occurrences}"
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] inputString = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string newString = string.Empty;
            foreach (var item in inputString)
            {
                newString += item;
            }

            string[] input = newString
                .ToArray()
                .Select(x => x.ToString())
                .ToArray();

            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item] += 1;
            }

            foreach (var (klyuch, stoinost) in dict)
            {
                Console.WriteLine($"{klyuch} -> {stoinost}");
            }

        }
    }
}
