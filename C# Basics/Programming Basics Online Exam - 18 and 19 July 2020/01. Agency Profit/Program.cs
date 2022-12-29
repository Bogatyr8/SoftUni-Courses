using System;

namespace _01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява печалбата на агенция за продажба на самолетни билети. Агенцията продава
            //самолетни билети на различни авиокомпании. Ще получите информация за броя продадени билети за възрастни и
            //броя продадени детски билети. Нетната цена на билета за възрастен се определя от авиокомпанията, а
            //детският билет е със 70 % по - евтин.Агенцията добавя към нетната цена на всеки билет такса обслужване.
            //Крайната печалба на Агенцията е 20 % от общата цена на всички билети.
            //Вход:
            //От конзолата се четат 5 реда:
            //1.Име на авиокомпанията -текст
            //2.Брой билети за   възрастни – цяло число в диапазона[1…400]
            //3.Брой детски билети – цяло число в диапазона[25…120]
            //4.Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
            //5.Цената на такса обслужване - реално число в диапазона[10.0…50.0]
            //Изход:
            //Да се отпечата на конзолата крайната печалбата от продажбите, в следния формат:
            //•	"The profit of your agency from {име на авиокомпанията} tickets is {печалба за агенцията} lv."
            //Цената на печалбата да бъде форматирана до втората цифра след десетичния знак.
            string avioCompany = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double netTicketPrizeForAdult = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());
            double netTicketPriceForAChild = netTicketPrizeForAdult - netTicketPrizeForAdult * 0.7;
            double agencyProfit = ((adultTickets * netTicketPrizeForAdult) + (kidTickets * netTicketPriceForAChild) + (adultTickets + kidTickets) * serviceTax) * 0.2;
            Console.WriteLine($"The profit of your agency from {avioCompany} tickets is {agencyProfit:f2} lv.");
        }
    }
}
