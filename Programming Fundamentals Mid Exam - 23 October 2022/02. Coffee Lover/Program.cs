using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command.Length == 0)
                {
                    break;
                }
                string order = command[0];

                if (order == "Include")
                {
                    if (command.Length < 2)
                    {
                        continue;
                    }
                    string coffee = command[1];
                    coffeeList.Add(coffee);
                }
                else if (order == "Remove")
                {
                    int index = 2;
                    if (command.Length < 3)
                    {
                        continue;
                    }
                    string firstOrLast = command[1];
                    int numberOfCoffees = int.Parse(command[2]);
                    if (numberOfCoffees < 0 && numberOfCoffees >= coffeeList.Count)
                    {
                        continue;
                    }

                    if (firstOrLast == "first")
                    {
                        coffeeList.RemoveRange(0, numberOfCoffees);
                    }
                    else if (firstOrLast == "last")
                    {
                        coffeeList.Reverse();
                        coffeeList.RemoveRange(0, numberOfCoffees);
                        coffeeList.Reverse();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (order == "Prefer")
                {
                    if (command.Length < 3)
                    {
                        continue;
                    }
                    int CoffeesIndex1 = int.Parse(command[1]);
                    int CoffeesIndex2 = int.Parse(command[2]);
                    if (CoffeesIndex1 < 0 
                        && CoffeesIndex2 < 0 
                        && CoffeesIndex1 >= coffeeList.Count 
                        && CoffeesIndex2 >= coffeeList.Count
                        && CoffeesIndex1 == CoffeesIndex2)
                    {
                        continue;
                    }
                    string coffee1 = coffeeList[CoffeesIndex1];
                    string coffee2 = coffeeList[CoffeesIndex2];
                    if (CoffeesIndex1 < CoffeesIndex2)
                    {
                        coffeeList.RemoveAt(CoffeesIndex2);
                        coffeeList.RemoveAt(CoffeesIndex1);
                        coffeeList.Insert(CoffeesIndex1, coffee2);
                        coffeeList.Insert(CoffeesIndex2, coffee1);
                    }
                    else if (CoffeesIndex1 > CoffeesIndex2)
                    {
                        coffeeList.RemoveAt(CoffeesIndex1);
                        coffeeList.RemoveAt(CoffeesIndex2);
                        coffeeList.Insert(CoffeesIndex2, coffee1);
                        coffeeList.Insert(CoffeesIndex1, coffee2);
                    }
                    else
                    {
                        continue;
                    }


                }
                else if (order == "Reverse")
                {
                    coffeeList.Reverse();
                }
            }

            PrintCoffeeList(coffeeList);
        }

        static void PrintCoffeeList(List<string> coffeeList)
        {
            Console.WriteLine($"Coffees:\n" + string.Join(" ", coffeeList));
        }
    }
}
