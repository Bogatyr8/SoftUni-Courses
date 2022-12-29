using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Атанас решава да прекара отпуската си в Банско и да кара ски. Преди да отиде обаче, трябва да резервира хотел и да изчисли
            //колко ще му струва престоя.Налични са следните видове помещения, със следните цени за престой:
            //§ "room for one person" – 18.00 лв за нощувка
            //§ "apartment" – 25.00 лв за нощувка
            //§ "president apartment" – 35.00 лв за нощувка
            //Според броят на дните, в които ще остане в хотела(пример: 11 дни = 10 нощувки) и видът на помещението, което ще избере, той
            //може да ползва различно намаление.
            //Намаленията са както следва:
            //вид помещение                 по - малко от 10 дни                между 10 и 15 дни               повече от 15 дни
            //  room for one person         не ползва намаление                 не ползва намаление             не ползва намаление
            //  apartment                   30 % от крайната цена               35 % от крайната цена           50 % от крайната цена
            //  president apartment         10 % от крайната цена               15 % от крайната цена           20 % от крайната цена
            //  След престоя, оценката на Атанас за услугите на хотела може да е позитивна(positive) или негативна(negative).Ако оценката му
            //  е позитивна, към цената с вече приспаднатото намаление Атанас добавя 25 % от нея.Ако оценката му е негативна приспада от
            //  цената 10 %.
            //  Вход
            //  Входът се чете от конзолата и се състои от три реда:
            //· Първи ред - дни за престой - цяло число в интервала[0...365]
            //· Втори ред - вид помещение - "room for one person", "apartment" или "president apartment"
            //· Трети ред - оценка - "positive" или "negative"
            //  Изход
            //  На конзолата трябва да се отпечата един ред:
            //· Цената за престоят му в хотела, форматирана до втория знак след десетичната запетая.
            int days = int.Parse(Console.ReadLine());
            string typeOfAccomodation = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double roomForOnePersonPrice = 18;
            double apartmentPrice = 25;
            double presidentApartmentPrice = 35;
            double price = 0;
            if (days > 0 && days < 10)
            {
                switch (typeOfAccomodation)
                {
                    case "room for one person":
                        price = (days - 1) * roomForOnePersonPrice;
                        break;
                    case "apartment":
                        price = (days - 1) * apartmentPrice;
                        price -= price * 0.3;
                        break;
                    case "president apartment":
                        price = (days - 1) * presidentApartmentPrice;
                        price -= price * 0.1;
                        break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (typeOfAccomodation)
                {
                    case "room for one person":
                        price = (days - 1) * roomForOnePersonPrice;
                        break;
                    case "apartment":
                        price = (days - 1) * apartmentPrice;
                        price -= price * 0.35;
                        break;
                    case "president apartment":
                        price = (days - 1) * presidentApartmentPrice;
                        price -= price * 0.15;
                        break;
                }
            }
            else if (days > 15)
            {
                switch (typeOfAccomodation)
                {
                    case "room for one person":
                        price = (days - 1) * roomForOnePersonPrice;
                        break;
                    case "apartment":
                        price = (days - 1) * apartmentPrice;
                        price -= price * 0.5;
                        break;
                    case "president apartment":
                        price = (days - 1) * presidentApartmentPrice;
                        price -= price * 0.2;
                        break;
                }
            }
            switch (evaluation)
            {
                case "positive":
                    price += price * 0.25;
                    break;
                case "negative":
                    price -= price * 0.1;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
