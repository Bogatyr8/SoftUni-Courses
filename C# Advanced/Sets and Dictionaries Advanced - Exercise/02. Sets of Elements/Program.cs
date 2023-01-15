namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that prints a set of elements.On the first line, you will receive two numbers -n
//and m, which represent the lengths of two separate sets.On the next n +m lines, you will receive
//n numbers, which are the numbers in the first set, and m numbers, which are in the second set.
//Find all the unique elements that appear in both of them and print them in the order in which
//they appear in the first set - n.
//For example:
//Set with length n = 4: { 1, 3, 5, 7}
//Set with length m = 3: { 3, 4, 5}
//Set that contains all the elements that repeat in both sets -> { 3, 5}
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            HashSet<int> common = new HashSet<int>();
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                first.Add(value);
            }
            for (int i = 0; i < m; i++)
            {
                int value = int.Parse(Console.ReadLine());
                second.Add(value);
            }

            foreach (int value1 in first)
            {
                if (second.Contains(value1))
                {
                    common.Add(value1);
                }
            }

            Console.WriteLine(String.Join(" ", common));

        }
    }
}
