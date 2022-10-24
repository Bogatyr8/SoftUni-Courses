using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
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
