using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with three
//positions forward. For example, A would be replaced by D, B would become E and so on. Print the encrypted text.
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                output.Append((char)(input[i] + 3));
            }

            Console.WriteLine(output);
        }
    }
}
