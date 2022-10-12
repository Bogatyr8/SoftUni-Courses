using System;
using System.Linq;
using System.Numerics;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, which prints all unique pairs in an array of integers whose sum is equal to a
            //given number.
            BigInteger[] input = Console.ReadLine()
                    .Split()
                    .Select(BigInteger.Parse)
                    .ToArray();
            BigInteger entryValue = BigInteger.Parse(Console.ReadLine());
            BigInteger[] dualValue = new BigInteger[2];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
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
