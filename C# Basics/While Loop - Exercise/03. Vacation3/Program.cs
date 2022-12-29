using System;

namespace _03._Vacation3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума.
            //Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото
            //има и ще ѝ останат 0 лева.
            //Вход
            //От конзолата се четат:
            //•	Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            //•	Налични пари -реално число в интервала[0.00...25000.00]
            //След това многократно се четат по два реда:
            //•	Вид действие – текст с възможности "spend" и "save"
            //•	Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]
            //Изход
            //Програмата трябва да приключи при следните случаи:
            //•	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            //o"You can't save the money."
            //o"{Общ брой изминали дни}"
            //•	Ако Джеси събере парите за почивката на конзолата се изписва:
            //o"You saved the money for {общ брой изминали дни} days."
            double budget = double.Parse(Console.ReadLine());
            double presentMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int spendingDays = 0;
            double presentSum = presentMoney;
            string order = Console.ReadLine();
            double amountOfMoney = double.Parse(Console.ReadLine());
            bool didSheSavedEnoughMoney = !(presentSum >= budget);
            while (didSheSavedEnoughMoney)
            {
                counter++;
                bool isSheSpending = order == "spend";
                bool isSheSaving = order == "save";
                if (isSheSpending)
                {
                    spendingDays++;
                    if (spendingDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{counter}");
                        break;
                    }
                    presentSum -= amountOfMoney;
                    if (presentSum < 0)
                    {
                        presentSum = 0;
                    }
                }
                else if (isSheSaving)
                {
                    spendingDays = 0;
                    presentSum += amountOfMoney;
                }
                didSheSavedEnoughMoney = !(presentSum >= budget);
                if (didSheSavedEnoughMoney)
                {
                    order = Console.ReadLine();
                    amountOfMoney = double.Parse(Console.ReadLine());
                }
            }
            if (!didSheSavedEnoughMoney)
            {
                Console.WriteLine($"You saved the money for {counter} days.");
            }
         }
    }
}
