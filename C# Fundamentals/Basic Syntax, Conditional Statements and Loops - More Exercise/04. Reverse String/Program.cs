using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int stringLength = input.Length;
            string reversedInput = string.Empty;
            for (int i = stringLength - 1; i >= 0; i--)
            {
                reversedInput += input[i];
            }
            Console.WriteLine(reversedInput);
        }
    }
}
