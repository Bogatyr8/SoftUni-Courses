using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program to calculate the total cost of different types of furniture.You will be given some lines of input, until you receive the line "Purchase".For the line to be valid it should be in the following format:
//">>{furniture name}<<{price}!{quantity}"
//The price can be a floating-point number or a whole number.Store the names of the furniture and the total price. At the end, print each bought furniture on a separate line in the format:
//"Bought furniture:
//{ 1st name}
//{ 2nd name}
//…"
//And on the last line, print the following: "Total money spend: {spend money}", formatted to the second decimal point.
            string pattern = @">>(?<title>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?";
            decimal sum = 0.0m;
            string input;

            Regex regex = new Regex(pattern);

            StringBuilder totalInput = new StringBuilder();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                totalInput.Append(input);
                totalInput.Append(" ");
            }
            string total = totalInput.ToString();

            MatchCollection list = regex.Matches(total);

            Console.WriteLine("Bought furniture:");

            foreach (Match item in list)
            {
                string title = item.Groups["title"].Value;
                string priceS = item.Groups["price"].Value;
                string quantityS = item.Groups["quantity"].Value;
                decimal price = decimal.Parse(priceS);
                decimal quantity = decimal.Parse(quantityS);
                sum += price * quantity;
                Console.WriteLine(title);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
