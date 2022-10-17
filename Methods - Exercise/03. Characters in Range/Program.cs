using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that receives two characters and prints all the characters between them according to
            //ASCII(on a single line).
            //NOTE: If the second letter's ASCII value is less than that of the first one then the two initial letters
            //should be swapped.
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char buffer = char.MinValue;

            if (a > b)
            {
                buffer = a;
                a = b;
                b = buffer;
            }

            PrintChars(a, b);
        }

        private static void PrintChars(char a, char b)
        {
            for (int i = a + 1; i < b; i++)
            {
                char c = (char)i;
                Console.Write(c + " ");
            }
        }
    }
}
