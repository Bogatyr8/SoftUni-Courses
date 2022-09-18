using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            while (true)
            {
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                input = int.Parse(Console.ReadLine());
            }
        }
    }
}
