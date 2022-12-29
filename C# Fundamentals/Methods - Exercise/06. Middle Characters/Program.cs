using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string.Create a method that prints the character found at its middle. If the length of the string
            //is even there are two middle characters.
            string input = Console.ReadLine();
            Console.WriteLine(MiddleChars(input));
        }
        static string MiddleChars(string text)
        {
            string middleText = string.Empty;
            int middle = 0;
            if (text.Length % 2 == 0)
            {
                middle = (text.Length - 1) / 2;
                middleText += text[middle];
                middleText += text[middle + 1];
            }
            else
            {
                middle = (text.Length - 1) / 2;
                middleText += text[middle];
            }
            return middleText;
        }
    }
}
