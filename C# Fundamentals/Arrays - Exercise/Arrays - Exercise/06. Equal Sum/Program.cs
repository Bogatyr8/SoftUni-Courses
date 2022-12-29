using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that determines if an element exists in an array for which the sum of all elements to
//its left is equal to the sum of all elements to its right.If there are no elements to the left or
//right, their sum is considered to be 0.Print the index of the element that satisfies the condition or
//"no" if there is no such element.
            long[] input = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            bool areConditionsMet = false;
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                long sumOnTheLeft = 0;
                long sumOnTheRight = 0;
                for (int j = 0; j <= i - 1; j++) // checking left side sum
                {
                        sumOnTheLeft += input[j];
                }

                for (int j = i + 1; j < input.Length; j++) // checking right side sum
                {
                        sumOnTheRight += input[j];
                }
                if (sumOnTheLeft == sumOnTheRight)
                {
                    areConditionsMet = true;
                    index = i;
                }
            }

            if (areConditionsMet)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
