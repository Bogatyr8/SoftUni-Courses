using System;

namespace _09.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете 2 * n - на брой цели числа, подадени от потребителя, и проверява дали сумата на първите n числа
            //(лява сума) е равна на сумата на вторите n числа(дясна сума). При равенство печата " Yes, sum = " + сумата; иначе печата
            //" No, diff = " + разликата.Разликата се изчислява като положително число(по абсолютна стойност).
            int sum1 = 0;
            int sum2 = 0;
            int counter = 1;
            int n = int.Parse(Console.ReadLine());
            for (int l = 1; l <= 2; l++)
            {
                for (int i = 1; i <= n; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (counter == 1)
                    {
                        sum1 += number;
                    }
                    if (counter == 2)
                    {
                        sum2 += number;
                    }
                }
                counter++;
            }
            bool isSum1EqualToSum2 = sum1 == sum2;
            if (isSum1EqualToSum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
