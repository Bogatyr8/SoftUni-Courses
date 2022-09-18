using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Friday    Saturday    Sunday
            //Students    8.45      9.80        10.46
            //Business    10.90     15.60       16
            //Regular     15        20          22.50
            //There are also discounts based on some conditions:
            //•	For Students, if the group is 30 or more people, you should reduce the total price by 15 %
            //•	For Business, if the group is 100 or more people, 10 of the people stay for free.
            //•	For Regular, if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %
            //Note: You should reduce the prices in that EXACT order!
            //As an output print the final price which the group is going to pay in the format: 
            //"Total price: {price}"
            //The price should be formatted to the second decimal point.
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0; 
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double totalPrice = price * numberOfPeople;
            if (numberOfPeople >= 30 && typeOfGroup == "Students")
            {
                totalPrice *= 0.85;
            }
            else if (numberOfPeople >= 100 && typeOfGroup == "Business")
            {
                totalPrice = totalPrice - (10 * price);
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 20 && typeOfGroup == "Regular")
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
