using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads a string from the console and replaces any sequence of the same letter with a single corresponding letter.
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    counter++;
                }
                else if (input[i - 1] != input[i] && counter != 0)
                {
                    input = input.Remove((i - counter), (counter));
                    counter = 0;
                    i = 0;
                }
                if (counter != 0 && i == input.Length - 1)
                {
                    input = input.Remove((i - counter), (counter));
                }
            }

            Console.WriteLine(input);
        }
    }
}
