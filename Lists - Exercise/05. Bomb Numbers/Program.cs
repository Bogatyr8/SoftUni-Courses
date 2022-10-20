using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a sequence of numbers and a special bomb number holding a certain power. Your task is to detonate every occurrence of the
            //special bomb number and according to its power the numbers to its left and right.The bomb power refers to how many numbers to the left and right will
            //be removed, no matter their values.Detonations are performed from left to right and all the detonated numbers disappear.Finally, print the sum of the
            //remaining elements in the sequence.
            List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
            int[] bomb = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            int bombPower = bomb[0];
            int bombRange = bomb[1];

            for (int i = 0; i < numbers.Count; i++) // Checking for bomb
            {
                if (numbers[i] == bombPower) // Kaboom!!!
                {
                    numbers.RemoveAt(i);
                    if (i < bombRange)
                    {
                        i = 0;
                        for (int j = 0; j < i + bombRange + 1; j++)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                    else if (i + bombRange > numbers.Count)
                    {
                        i -= bombRange;
                        for (int j = 0; j < numbers.Count - i + bombRange; j++)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                    else
                    {
                        i -= bombRange;
                        for (int j = 0; j < 2 * bombRange; j++)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
