using System;

namespace _08.Numbersequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool isNumberBiggerThanMaxNumber = number >= maxNumber;
                bool isNumberSmallerThanMinNumber = number <= minNumber;
                if (isNumberBiggerThanMaxNumber)
                {
                    maxNumber = number;
                }
                if (isNumberSmallerThanMinNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
