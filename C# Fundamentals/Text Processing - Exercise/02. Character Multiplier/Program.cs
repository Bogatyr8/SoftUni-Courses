using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that takes two strings as arguments and returns the sum of their character codes multiplied. Multiply str1[0]
            //with str2[0] and add to the total sum. Then continue with the next two characters. If one of the strings is longer than the other,
            //add the remaining character codes to the total sum without multiplication.
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string wordOne = input[0];
            string wordTwo = input[1];
            
            int sum = SumOfCharMultiplier(wordOne, wordTwo);

            Console.WriteLine(sum);
        }

        static int SumOfCharMultiplier(string wordOne, string wordTwo)
        {
            int sum = 0;
            string sub = string.Empty;
            int commonLength = Math.Min(wordOne.Length, wordTwo.Length);
            for (int i = 0; i < commonLength; i++)
            {
                sum += (wordOne[i] * wordTwo[i]);
            }
            if (wordOne.Length > wordTwo.Length)
            {
                sub = wordOne.Substring(commonLength);
            }
            else if (wordOne.Length < wordTwo.Length)
            {
                sub = wordTwo.Substring(commonLength);
            }
            else
            {
                return sum;
            }

            for (int i = 0; i < sub.Length; i++)
            {
                sum += sub[i];
            }
            return sum;
        }
    }
}
