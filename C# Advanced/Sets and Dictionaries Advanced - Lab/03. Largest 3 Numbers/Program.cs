namespace _03._Largest_3_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Read a list of integers and print the largest 3 of them. If there are less than 3, print all of
//them.
//  Hints
//•	Read an array of integers.
//•	Order the array using a LINQ query.
//•	Print top 3 numbers with a for loop.
            string inputLine = Console.ReadLine();
            int[] input = inputLine
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int[] sorted = input.OrderByDescending(x => x).ToArray();
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
        }
    }
}
