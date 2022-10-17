using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads positive integers until you receive the "END" command.  For each number, print whether the
//number is a palindrome or not. A palindrome is a number that reads the same backward as forward, such as 323 or 1001. 
            string input = Console.ReadLine();
            while (input != "END")
            {

                Console.WriteLine(PalindromeChecker(input));
                input = Console.ReadLine();
            }
            
        }

        static bool PalindromeChecker(string input)
        {
            string reversed = string.Empty;
            for (int i = (input.Length - 1); i >= 0 ; i--)
            {
                reversed += input[i];
            }
            if (input == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
