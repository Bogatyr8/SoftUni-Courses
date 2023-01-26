using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of integers separated by ", ".Then prints the even numbers of that sequence sorted in increasing order.
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
