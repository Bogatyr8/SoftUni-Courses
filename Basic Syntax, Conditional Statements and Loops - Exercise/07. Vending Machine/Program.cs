using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double deposit = 0;
            double price = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                switch (coins)
                {
                    case 0.1:
                        deposit += coins;
                        break;
                    case 0.2:
                        deposit += coins;
                        break;
                    case 0.5:
                        deposit += coins;
                        break;
                    case 1:
                        deposit += coins;
                        break;
                    case 2:
                        deposit += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        price = 2;

                        deposit -= price;
                        if (deposit >= 0)
                        {
                            Console.WriteLine($"Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            deposit += price;
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        deposit -= price;
                        if (deposit >= 0)
                        {
                            Console.WriteLine($"Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            deposit += price;
                        }
                        break;
                    case "Crisps":
                        price = 1.5;
                        deposit -= price;
                        if (deposit >= 0)
                        {
                            Console.WriteLine($"Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            deposit += price;
                        }
                        break;
                    case "Soda":
                        price = 0.8;
                        deposit -= price;
                        if (deposit >= 0)
                        {
                            Console.WriteLine($"Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            deposit += price;
                        }
                        break;
                    case "Coke":
                        price = 1;
                        deposit -= price;
                        if (deposit >= 0)
                        {
                            Console.WriteLine($"Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                            deposit += price;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {deposit:f2}");
        }
    }
}
