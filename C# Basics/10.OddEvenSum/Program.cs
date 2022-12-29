using System;

namespace _10.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете n-на брой цели числа, подадени от потребителя и проверява дали сумата от числата на четни
            //позиции е равна на сумата на числата на нечетни позиции.
            //· Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата;
            //· Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата.
            //Разликата се изчислява по абсолютна стойност. 
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool isItEvenRow = i % 2 == 0;
                if (isItEvenRow)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }

            }
            bool areTheyEqual = sumOdd == sumEven;
            if (areTheyEqual)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
