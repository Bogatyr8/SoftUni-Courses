using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
//Let's take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the
//person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a
//line with the text "end of shift", you will be given lines of input. But before processing that line, you have to do some
//validations first.
//Each valid order should have a customer, product, count and a price:
//•	A valid customer's name should be surrounded by ' % ' and must start with a capital letter, followed by lower-case letters.
//•	A valid product contains any word character and must be surrounded by '<' and '>'.
//•	A valid count is an integer, surrounded by '|'.
//•	A valid price is any real number followed by '$'.
//The parts of a valid order should appear in the order given: customer, product, count and price.
//Between each part there can be other symbols, except '|', '$', '%' and '.'.
//For each valid line, print on the console: "{customerName}: {product} - {totalPrice}".
//When you receive "end of shift" print the total amount of money for the day, rounded to 2 decimal places in the following
//format: "Total income: {income}".
//Input / Constraints
//•	Strings that you have to process until you receive text "end of shift".
//Output
//•	Print all of the valid lines in the format "{customerName}: {product} - {totalPrice}".
//•	After receiving "end of shift", print the total amount of money for the day, rounded to 2 decimal places in the following
//format: "Total income: {income}".
//•	Allowed working time / memory: 100ms / 16MB.
            string pattern = @"%(?<name>[A-Z][a-z]+)%([^|$%.]*)<(?<product>\w+)>([^\|$%.]*)\|(?<count>\d+)\|([^|$%.]*?)(?<price>\d+(?:\.\d+)?)\$";
            decimal totalIncome = 0.0m;
            Regex regex = new Regex(pattern);
            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{name}: {product} - {(count * price):f2}");
                    totalIncome += (count * price);
                }
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
