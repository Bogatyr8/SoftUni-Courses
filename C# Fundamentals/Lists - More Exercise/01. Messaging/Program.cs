﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
//You will be given a list of numbers and a string.For each element of the list you must calculate the sum of its digits and take the element, corresponding
//to that index from the text.If the index is greater than the length of the text, start counting from the beginning (so that you always have a valid index).
//After you get that element from the text, you must remove the character you have taken from it(so for the next index the text will be with one characterless).

            string numbers = Console.ReadLine();
            List<string> listOfNumbers = numbers
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string hiddenCode = Console.ReadLine();

            List<char> theCode= new List<char>();

            for (int i = 0; i < hiddenCode.Length; i++)
            {
                theCode.Add(hiddenCode[i]);
            }

            int count = 0;
            string output = string.Empty;
            while (listOfNumbers.Count != 0)
            {
                int sum = 0;
                int value = int.Parse(listOfNumbers[0]);

                for (int i = 0; i < listOfNumbers[0].Length; i++)
                {
                    sum += value % 10;
                    value /= 10;
                }

                output += theCode[sum % theCode.Count];
                theCode.RemoveAt(sum % theCode.Count);
                listOfNumbers.RemoveAt(0);
                count++;
            }

            Console.WriteLine(output);
        }
    }
}
