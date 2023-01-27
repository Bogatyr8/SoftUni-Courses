namespace _04._Add_VAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads one line of double prices separated by ", ". Print the prices with added VAT for all of them. Format them to
//2 signs after the decimal point. The order of the prices must be the same.
//VAT is equal to 20 % of the price.
            Func<double, double> vat = VAT;
            Func<string, double> parseDouble = ParseToDouble;
            double[] prices = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(parseDouble)
                    .Select(vat)
                    .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
                
        }

        private static double VAT(double price)
        {
            return price * 1.2;
        }
        private static double ParseToDouble(string price)
        {
            return double.Parse(price);
        }
    }
}
