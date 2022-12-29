using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceOfFlour = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfApron = decimal.Parse(Console.ReadLine());

            int freePackages = students / 5;
            var extraAprons = Math.Ceiling((decimal)students / 5);
            decimal totalPrice = ((10 * priceOfEggs + priceOfApron) * students) + (extraAprons * priceOfApron) + priceOfFlour * (students - freePackages);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(Math.Abs(budget - totalPrice)):f2}$ more needed.");
            }
        }
    }
}
