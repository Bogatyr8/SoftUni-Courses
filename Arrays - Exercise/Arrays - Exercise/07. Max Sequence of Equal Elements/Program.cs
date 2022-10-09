using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the longest sequence of equal elements in an array of integers. If several
            //equal sequences are present in the array, print out the leftmost one.
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sameDigitCounter = 1;
            int currentDigit = 0;
            int maxSameDigitCounter = 0;
            int maxDigit = 0;
            for (int i = input.Length - 1; i >= 1; i--)
            {
                if ((input[i] - input[i - 1]) == 0)
                {
                    currentDigit = input[i];
                    sameDigitCounter++;
                }
                else
                {
                    sameDigitCounter = 1;
                }
                if (sameDigitCounter >= maxSameDigitCounter)
                {
                    maxSameDigitCounter = sameDigitCounter;
                    maxDigit = currentDigit;
                }
            }
            for (int i = 0; i < maxSameDigitCounter; i++)
            {
                Console.Write($"{maxDigit} ");
            }
        }
    }
}
