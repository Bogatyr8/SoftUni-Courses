using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int value = int.Parse(input);
                if (value < minValue)
                {
                    minValue = value;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minValue);
        }
    }
}
