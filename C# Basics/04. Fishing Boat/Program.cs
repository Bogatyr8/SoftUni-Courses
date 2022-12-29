using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тони и приятели много обичали да ходят за риба, те са толкова запалени по риболова, че решават да отидат на риболов с кораб.
            //Цената за наема на кораба зависи от сезона и броя рибари.
            //Цената зависи от сезона:
            //· Цената за наем на кораба през пролетта е 3000 лв.
            //· Цената за наем на кораба през лятото и есента е 4200 лв.
            //· Цената за наем на кораба през зимата е 2600 лв.
            //В зависимост от броя си групата ползва отстъпка:
            //· Ако групата е до 6 човека включително – отстъпка от 10 %.
            //· Ако групата е от 7 до 11 човека включително – отстъпка от 15 %.
            //· Ако групата е от 12 нагоре – отстъпка от 25 %.
            //Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен - тогава нямат допълнителна отстъпка, която
            //се начислява след като се приспадне отстъпката по горните критерии.
            // Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари.
            //Вход
            //От конзолата се четат точно три реда.
            //· Бюджет на групата – цяло число в интервала[1…8000]
            //· Сезон – текст: "Spring", "Summer", "Autumn", "Winter"
            //· Брой рибари – цяло число в интервала[4…18]
            //Изход
            //Да се отпечата на конзолата един ред:
            //· Ако бюджетът е достатъчен:
            //"Yes! You have {останалите пари} leva left."
            //· Ако бюджетът НЕ Е достатъчен:
            //"Not enough money! You need {сумата, която не достига} leva."
            //Сумите трябва да са форматирани с точност до два знака след десетичната запетая.
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            double rentOfBoat = 0;
            switch (season)
            {
                case "Spring":
                    rentOfBoat = 3000;
                    if ( numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.1);
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.15);
                    }
                    else if (numberOfPeople >= 12)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.25);
                    }
                    if (numberOfPeople % 2 == 0)
                    {
                        rentOfBoat -= rentOfBoat * 0.05;
                    }
                    break;
                case "Summer":
                    rentOfBoat = 4200;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.1);
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.15);
                    }
                    else if (numberOfPeople >= 12)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.25);
                    }
                    if (numberOfPeople % 2 == 0)
                    {
                        rentOfBoat -= rentOfBoat * 0.05;
                    }
                    break;
                case "Autumn":
                    rentOfBoat = 4200;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.1);
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.15);
                    }
                    else if (numberOfPeople >= 12)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.25);
                    }
                    break;
                case "Winter":
                    rentOfBoat = 2600;
                    if (numberOfPeople > 0 && numberOfPeople <= 6)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.1);
                    }
                    else if (numberOfPeople >= 7 && numberOfPeople <= 11)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.15);
                    }
                    else if (numberOfPeople >= 12)
                    {
                        rentOfBoat = rentOfBoat - (rentOfBoat * 0.25);
                    }
                    if (numberOfPeople % 2 == 0)
                    {
                        rentOfBoat -= rentOfBoat * 0.05;
                    }
                    break;
            }

            bool isBudgetEnough = rentOfBoat <= budget;
            if (isBudgetEnough)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(rentOfBoat - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rentOfBoat - budget):f2} leva.");
            }
        }
    }
}
