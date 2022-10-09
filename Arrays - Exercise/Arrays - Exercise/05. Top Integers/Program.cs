using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            bool isItBiggerThanTheRest = true;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] < input[j])
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
