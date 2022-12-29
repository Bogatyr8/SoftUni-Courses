using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да
            //изчисли колко ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с
            //различни цени.
            //цвете                     Роза        Далия       Лале        Нарцис      Гладиола
            //Цена на брой в лева        5          3.80        2.80        3           2.50
            //Съществуват следните отстъпки:
            //· Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //· Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            //· Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //· Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //· Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            //От конзолата се четат 3 реда:
            //· Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //· Брой цветя -цяло число в интервала[10…1000]
            //· Бюджет - цяло число в интервала[50…2500]
            //Да се отпечата на конзолата на един ред:
            //· Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //· Ако бюджета им е НЕ достатъчен -"Not enough money, you need {нужната сума} leva more."
            //Сумата да бъде форматирана до втория знак след десетичната запетая.
            string flowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double pricePerFlower = 0;
            double totalPrice = 0;
            switch (flowers)
            {
                case "Roses":
                    pricePerFlower = 5.0;
                    totalPrice = number * pricePerFlower;
                    if (number > 80)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.1);
                    }
                    break;
                case "Dahlias":
                    pricePerFlower = 3.8;
                    totalPrice = number * pricePerFlower;
                    if (number > 90)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    break;
                case "Tulips":
                    pricePerFlower = 2.8;
                    totalPrice = number * pricePerFlower;
                    if (number > 80)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.15);
                    }
                    break;
                case "Narcissus":
                    pricePerFlower = 3.0;
                    totalPrice = number * pricePerFlower;
                    if (number < 120)
                    {
                        totalPrice = totalPrice + (totalPrice * 0.15);
                    }
                    break;
                case "Gladiolus":
                    pricePerFlower = 2.5;
                    totalPrice = number * pricePerFlower;
                    if (number < 80)
                    {
                        totalPrice = totalPrice + (totalPrice * 0.2);
                    }
                    break;
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {Math.Abs(totalPrice - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(totalPrice - budget):f2} leva more.");
            }
        }
    }
}
