using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            //Хотел предлага 2 вида стаи: студио и апартамент. Напишете програма, която изчислява цената за целия престой за студио и
            //апартамент. Цените зависят от месеца на престоя:
            //      Май и октомври                   Юни и септември                                Юли и август
            //      Студио – 50 лв./ нощувка         Студио – 75.20 лв./ нощувка                    Студио – 76 лв./ нощувка
            //      Апартамент – 65 лв./ нощувка     Апартамент – 68.70 лв./ нощувка                Апартамент – 77 лв./ нощувка
            //Предлагат се и следните отстъпки:
            //· За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            //· За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            //· За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            //· За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.
            //Вход
            //Входът се чете от конзолата и съдържа точно 2 реда, въведени от потребителя:
            //· На първия ред е месецът – May, June, July, August, September или October
            //· На втория ред е броят на нощувките – цяло число в интервала[0... 200]
            //Изход
            //Да се отпечатат на конзолата 2 реда:
            //· На първия ред: “Apartment: { цена за целият престой} lv.”
            //· На втория ред: “Studio: { цена за целият престой} lv.“
            //Цената за целия престой форматирана с точност до два знака след десетичната запетая.
            string month = Console.ReadLine();
            int reservedDays = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceFlat = 0;
            double totalPriceStudio = 0;
            double totalPriceFlat = 0;
            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceFlat = 65;
                    totalPriceStudio = reservedDays * priceStudio;
                    totalPriceFlat = reservedDays * priceFlat;
                    if (reservedDays > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.3;
                    }
                    else if (reservedDays > 7)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.05;
                    }
                    if (reservedDays > 14)
                    {
                        totalPriceFlat -= totalPriceFlat * 0.1;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceFlat = 68.70;
                    totalPriceStudio = reservedDays * priceStudio;
                    totalPriceFlat = reservedDays * priceFlat;
                    if (reservedDays > 14)
                    {
                        totalPriceStudio -= totalPriceStudio * 0.2;
                    }
                    if (reservedDays > 14)
                    {
                        totalPriceFlat -= totalPriceFlat * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceFlat = 77;
                    totalPriceStudio = reservedDays * priceStudio;
                    totalPriceFlat = reservedDays * priceFlat;
                    if (reservedDays > 14)
                    {
                        totalPriceFlat -= totalPriceFlat * 0.1;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {totalPriceFlat:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
