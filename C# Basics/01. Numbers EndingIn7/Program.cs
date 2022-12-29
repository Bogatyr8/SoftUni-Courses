using System;

namespace _01._Numbers_EndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int i = 0; i <= 1000; i++)
            {
                bool isItEndingIn7 = number % 10 == 7;
                if (isItEndingIn7)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
