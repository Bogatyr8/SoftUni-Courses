using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity.If the product doesn't exist yet, add it with its starting quantity.
//If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
//You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
//Input
//•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
//•	The product data is always delimited by a single space.
//Output
//•	Print information about each product in the following format:
//"{productName} -> {totalPrice}"
//•	Format the average grade to the 2nd digit after the decimal separator.
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string inputString;

            while ((inputString = Console.ReadLine()) != "buy")
            {
                string[] input = inputString
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                string price = input[1];
                string quantity = input[2];
                double priceValue = 0.0;
                double quantityValue = 0.0;
                if (!products.ContainsKey(name))
                {
                    double[] priceAndQuantity = $"{price}:{quantity}"
                        .Split(":", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    products.Add(name, priceAndQuantity);
                }
                else
                {
                    priceValue = double.Parse(price);
                    quantityValue += double.Parse(quantity);
                    products[name][0] = priceValue;
                    products[name][1] += quantityValue;
                }
            }

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
