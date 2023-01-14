namespace _04._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints information about food shops in Sofia and the products
            //they store. Until the "Revision" command is received, you will be receiving input in
            //the format: "{shop}, {product}, {price}".Keep in mind that if you receive a shop you
            //already have received, you must collect its product information.
            //Your output must be ordered by shop name and must be in the format:
            //"{shop}->
            //Product: { product}, Price: { price}"
            //Note: The price should not be rounded or formatted.
            Dictionary<string, Dictionary<string, double>> goods = 
                new Dictionary<string, Dictionary<string, double>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputArr = input.Split(", ");
                string shop = inputArr[0];
                string product = inputArr[1];
                double price = double.Parse(inputArr[2]);
                if (!goods.ContainsKey(shop))
                {
                    goods.Add(shop, new Dictionary<string, double>());
                }
                if (!goods[shop].ContainsKey(product))
                {
                    goods[shop].Add(product, 0);
                }
                goods[shop][product] = price;
            }

            goods = goods
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value.Keys)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var shop in goods)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var good in shop.Value)
                {
                    Console.WriteLine($"Product: {good.Key}, Price: {good.Value}");
                }
            }
        }
    }
}
