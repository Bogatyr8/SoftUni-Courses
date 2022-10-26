using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
//Write a program that mixes up two lists by some rules.You will receive two lines of input, each one being a list of numbers.The mixing rules are:
//•	Start from the beginning of the first list and the ending of the second.
//•	Add element from the first and element from the second.
//•	In the end, there will always be a list, in which there are 2 elements are remaining.
//•	These elements will be the range of the elements you need to print.
//•	Loop through the result list and take only the elements that fulfill the condition.
//•	Print the elements ordered in ascending order and separated by a space.
            List<int> input1 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            List<int> input2 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            List<int> combined = new List<int>();
            int count = Math.Min(input1.Count, input2.Count);

            for (int i = 0; i < count; i++)
            {
                combined.Add(input1[0]);
                input1.RemoveAt(0);
                combined.Add(input2[input2.Count - 1]);
                input2.RemoveAt(input2.Count - 1);
            }

            int Range1 = 0;
            int Range2 = 0;

            if (input2.Count == 0)
            {
                Range1 = input1[0];
                Range2 = input1[1];
            }
            else
            {
                Range1 = input2[0];
                Range2 = input2[1];
            }

            List<int> reduced = new List<int>();
            int min = Math.Min(Range1, Range2);
            int max = Math.Max(Range1, Range2);

            for (int i = 0; i < combined.Count; i++)
            {
                if (combined[i] > min && combined[i] < max)
                {
                    reduced.Add(combined[i]);
                }
            }

            Console.WriteLine(string.Join(" ", reduced.OrderBy(x => x)));
        }
    }
}
