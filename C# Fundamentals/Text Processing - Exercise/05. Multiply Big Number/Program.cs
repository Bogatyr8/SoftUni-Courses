using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
//You are given two lines – the first one can be a really big number (0 to 1050). The second one will be a single-digit number (0 to 9). Your task is to display the product of these numbers.
//Note: do not use the BigInteger class.
            string input1 = Console.ReadLine();
            int input2 = int.Parse(Console.ReadLine());
            int credit = 0;
            string input = input1;
            if (input1[0] == '-')
            {
                input = input1.Substring(1);
            }

            StringBuilder product = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int tempValue = ((input[i] - 48) * Math.Abs(input2)) + credit;
                credit = tempValue / 10;
                char currentDigit = (char)((tempValue % 10) + 48);
                product.Append(currentDigit);
            }
            if (credit > 0)
            {
                product.Append(credit);
            }
            if (input1[0] == '-' || input2 < 0)
            {
                product.Append('-');
            }
            if (input1[0] == '-' && input2 < 0)
            {
                product.Remove(product.Length - 1, 1);
            }
            string strProduct = product.ToString();
            char[] charArray = strProduct.ToCharArray();
            Array.Reverse(charArray);
            string output = new string(charArray);
            if (input2 == 0)
            {
                output = "0";
            }

            Console.WriteLine(output);

        }
    }
}
