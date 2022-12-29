using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name                        Price
            //OutFall 4                   $39.99
            //CS: OG                      $15.99
            //Zplinter Zell	              $19.99
            //Honored 2                   $59.99
            //RoverWatch                  $29.99
            //RoverWatch Origins Edition  $39.99
            double balance = double.Parse(Console.ReadLine());
            double change = 0;
            double order = 0;
            string gameTitle = Console.ReadLine();
            bool flag = false;
            while (gameTitle != "Game Time")
            {
                double price = 0;
                flag = false;
                switch (gameTitle)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (gameTitle == "OutFall 4" || gameTitle == "CS: OG" || 
                    gameTitle == "Zplinter Zell" || gameTitle == "Honored 2" || 
                    gameTitle == "RoverWatch" || gameTitle == "RoverWatch Origins Edition")
                {
                    order += price;
                    if (order > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        order -= price;
                    }
                    else if (order <= balance)
                    {
                        Console.WriteLine($"Bought {gameTitle}");
                    }

                    if (order == balance)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                flag = true;
                gameTitle = Console.ReadLine();
            }
            if (flag)
            {
                Console.WriteLine($"Total spent: ${order:f2}. Remaining: ${(balance - order):f2}");
            }
        }
    }
}
