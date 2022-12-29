using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, въведени от потребителя,и проверява дали сред тях съществува число, което
            //е равно на сумата на всички останали.
            //· Ако има такъв елемент печата "Yes" и на нов ред "Sum = " + неговата стойност
            //· Ако няма такъв елемент печата "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите (по
            //абсолютна стойност)
            int sum = 0;
            int maxN = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool isNumberBiggerThanMaxN = number > maxN;
                if (isNumberBiggerThanMaxN)
                {
                    maxN = number;
                }
                sum += number;
            }
            bool isMaxNEqualToSumOfOthers = (sum - maxN) == maxN;
            if (isMaxNEqualToSumOfOthers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxN}");
            }
            else
            {

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxN - Math.Abs(sum - maxN))}");
            }
        }
    }
}
