using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                int digitLength = input.Length;
                int numerical = int.Parse(input);
                int mainDigit = numerical % 10;
                int offset = ((mainDigit) - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                char signInASCII = (char)(letterIndex + 97);
                if (mainDigit == 0)
                {
                    signInASCII = (char)32;
                }
                text += signInASCII;
            }
            Console.WriteLine(text);
        }
    }
}
