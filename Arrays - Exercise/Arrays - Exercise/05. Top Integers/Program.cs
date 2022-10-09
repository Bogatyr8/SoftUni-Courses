using System;
using System.Linq;
using System.Numerics;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to find all the top integers in an array. A top integer is an integer that
            //is greater than all the elements to its right.
            BigInteger[] input = Console.ReadLine()
                .Split()
                .Select(BigInteger.Parse)
                .ToArray();
            bool isItBiggerThanTheRest = true;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isItBiggerThanTheRest = false;
                        break;
                    }
                }

                if (!isItBiggerThanTheRest)
                {
                    isItBiggerThanTheRest = true;
                    continue;
                }

                Console.Write($"{input[i]} ");
            }
        }
    }
}
