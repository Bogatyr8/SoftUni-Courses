using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Снимките за дългоочаквания филм "Годзила срещу Конг" започват.Сценаристът Адам Уингард ви моли да
            //напишете програма, която да изчисли, дали предвидените средства са достатъчни за снимането на филма.
            //За снимките ще бъдат нужни определен брой статисти, облекло за всеки един статист и декор.
            //Известно е, че:
            // Декорът за филма е на стойност 10 % от бюджета.
            // При повече от 150 статиста, има отстъпка за облеклото на стойност 10 %.
            //Вход
            //От конзолата се четат 3 реда:
            //Ред 1.Бюджет за филма – реално число в интервала[1.00... 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1... 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00... 1000.00]
            //Изход
            //На конзолата трябва да се отпечатат два реда:
            // Ако парите за декора и дрехите са повече от бюджета:
            //o "Not enough money!"
            //o "Wingard needs {парите недостигащи за филма} leva more."
            // Ако парите за декора и дрехите са по малко или равни на бюджета:
            //o "Action!"
            //o "Wingard starts filming with {останалите пари} leva left."
            //Резултатът трябва да е форматиран до втория знак след десетичната запетая.
            double budget = double.Parse(Console.ReadLine());
            int numberOfCast = int.Parse(Console.ReadLine());
            double clothingPricePerPerson = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            bool areThereMoreThan150Cast = numberOfCast > 150;
            if (areThereMoreThan150Cast)
            {
                clothingPricePerPerson *= 0.9;
            }
            double totalSum = numberOfCast * clothingPricePerPerson + decor;
            bool isBudgetEnough = totalSum <= budget;
            if (isBudgetEnough)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(totalSum - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(totalSum - budget):f2} leva more.");
            }
        }
    }
}
