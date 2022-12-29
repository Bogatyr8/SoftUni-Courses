using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            //· Premiere – премиерна прожекция, на цена 12.00 лева.
            //· Normal – стандартна прожекция, на цена 7.50 лева.
            //· Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int seats = row * column;
            double profit = 0;
            switch (type)
            {
                case "Premiere":
                    profit = seats * 12.00;
                    break;
                case "Normal":
                    profit = seats * 7.50;
                    break;
                case "Discount":
                    profit = seats * 5.00;
                    break;
            }
            Console.WriteLine($"{profit:f2} leva");
        }
    }
}
