using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
//A top number is an integer that holds the following properties:
//•	Its sum of digits is divisible by 8, e.g. 8, 17, 88
//•	Holds at least one odd digit, e.g. 232, 707, 87578
//•	Some examples of top numbers are: 17, 161, 251, 4310, 123200
//Create a program to print all top numbers in the range[1…n].
//You will receive a single integer from the console, representing the end value. Examples
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                int[] digits = SplitingTODigits(i); // Digits of n are converted as elements of array
                bool isThereSumDevBy8 = CheckForDivisibilityOfSumOfDigitsBy8(digits);
                bool isThereOddDigit = CheckForOddDigit(digits);
                if (isThereSumDevBy8 && isThereOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckForOddDigit(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckForDivisibilityOfSumOfDigitsBy8(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int[] SplitingTODigits( int number)
        {
            int counter = 0;
            int temporaryValue = number;
            bool isItZero = temporaryValue == 0;
            if (number == 0)
            {
                counter = 1;
            }
            while (!isItZero)
            {
                counter++;
                temporaryValue /= 10;
                isItZero = temporaryValue == 0;
            }

            int[] digits = new int[counter];
            for (int i = counter - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }
    }
}
