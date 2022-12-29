using System;
using System.Linq;

namespace _03._The_Angry_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

            int sumLeft = 0;
            int sumRight = 0;
            if (entryPoint >= 1 && entryPoint <= priceRatings.Length - 2)
            {
                for (int i = entryPoint - 1; i >= 0; i--)  //leftward
                {
                    if (typeOfItems == "cheap")
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                    else if (typeOfItems == "expensive")
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            sumLeft += priceRatings[i];
                        }
                    }
                }


                for (int i = entryPoint + 1; i < priceRatings.Length; i++)  //rightward
                {
                    if (typeOfItems == "cheap")
                    {
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                    else if (typeOfItems == "expensive")
                    {
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            sumRight += priceRatings[i];
                        }
                    }
                }
            }

            if (sumLeft > sumRight)
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
            else if (sumLeft < sumRight)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }
    }
}
