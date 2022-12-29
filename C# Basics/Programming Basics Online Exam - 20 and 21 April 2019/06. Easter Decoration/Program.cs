using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalBasket = 0;
            int clients = int.Parse(Console.ReadLine());
            for (int i = 1; i <= clients; i++)
            {
                double basket = 0;
                int basketCounter = 0;
                string products = Console.ReadLine();
                while (products != "Finish")
                {
                    switch (products)
                    {
                        case "basket":
                            basket += 1.5;
                            basketCounter++;
                            break;
                        case "wreath":
                            basket += 3.8;
                            basketCounter++;
                            break;
                        case "chocolate bunny":
                            basket += 7;
                            basketCounter++;
                            break;
                    }
                    products = Console.ReadLine();
                }
                if (basketCounter % 2 == 0)
                {
                    basket *= 0.8;
                }
                totalBasket += basket;
                Console.WriteLine($"You purchased {basketCounter} items for {basket:f2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {totalBasket / clients:f2} leva.");
        }
    }
}
