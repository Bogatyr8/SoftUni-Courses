using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which prints all unique pairs in an array of integers whose sum is equal to a
            //given number.
            int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            int entryValue = int.Parse(Console.ReadLine());
            int[] dualValue = new int[2];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if ((input[i] + input[j]) == entryValue)
                    {
                        dualValue[0] = input[i];
                        dualValue[1] = input[j];
                        Console.WriteLine(string.Join(" ", dualValue));
                    }
                }
            }
        }
    }
}
