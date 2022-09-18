using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numberLenght = input.Length;
            int number = int.Parse(input);
            int factoriel = 1;
            int sum = 0;
            double devider = 0;
            int number2 = number;
            for (int i = numberLenght; i >= 1; i--)
            {
                devider = Math.Pow(10.0, i - 1);
                int ratio = number2 / (int)devider;
                factoriel = 1;
                for (int j = 1; j <= ratio; j++)
                {
                    factoriel *= j;
                }
                sum += factoriel;
                number2 %= (int)devider;
            }
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
