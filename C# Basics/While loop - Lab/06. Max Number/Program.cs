using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-голямото
            //измежду тях. Въвежда се по едно число на ред.
            int maxValue = int.MinValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int value = int.Parse(input);
                if (value > maxValue)
                {
                    maxValue = value;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxValue);
        }
    }
}
