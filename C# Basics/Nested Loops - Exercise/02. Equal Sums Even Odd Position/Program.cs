using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата две шестцифрени цели числа в диапазона от 100000 до 300000.Винаги първото въведено число
            //ще бъде по малко от второто. На конзолата да се отпечатат на 1 ред разделени с интервал всички числа, които се намират между двете,
            //прочетени от конзолата числа и отговарят на следното условие:
            //•	сумата от цифрите на четни и нечетни позиции да са равни.Ако няма числа, отговарящи на условието на конзолата не се извежда
            //резултат.
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                int sumOdds = 0;
                int sumEvens = 0;
                string currentNumber = i.ToString();
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    if (j % 2 == 0)
                    {
                        sumOdds += currentDigit;
                    }
                    else
                    {
                        sumEvens += currentDigit;
                    }
                }
                if (sumEvens == sumOdds)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
