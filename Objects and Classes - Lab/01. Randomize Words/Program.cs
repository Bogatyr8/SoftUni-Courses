using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.
            string inputString = Console.ReadLine();
            string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);

                string currentWord = input[i];
                string nextWord = input[randomIndex];

                input[i] = nextWord;
                input[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
