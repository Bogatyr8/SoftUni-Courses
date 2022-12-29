using System;

namespace _02BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            //По време на мач Пепи решава да си купи бира и чипс от магазинчето в стадиона. Вашата задача е да
            //напишете програма, с която ще разберете дали има необходимите пари и дали ще успее да си закупи
            //съответните неща. Цената на една бира е 1.20 лв., а цената на един пакет чипс е равна на 45 % от
            //общата стойност на закупените бири.Общата цена на чипса да се закръгли до по - голямо число.
            //Вход
            //От конзолата се четат 4 реда:
            //•	На първия ред - името на футболният фен – текст
            //•	На втория ред - предвиденият бюджет  – реално число в диапазона[1.0… 100 000.0]
            //•	На третия ред - брой бутилки бира – цяло число в диапазона[1… 100 000]
            //•	На четвърти ред - брой пакети чипс – цяло число в диапазона[1… 100 000]
            //Изход
            //Да се отпечата един ред:
            //•	Ако бюджетът е достатъчен за закупуването на продуктите: 
            // "{име} bought a snack and has {останали пари} leva left."
            //•	Ако бюджетът НЕ е достатъчен:
            //"{име} needs {нужни пари} more leva!"
            //Резултатът да се форматира до втория знак след десетичната запетая.

            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numberOfBeers = int.Parse(Console.ReadLine());
            int numberOfChips = int.Parse(Console.ReadLine());

            double costOfBeers = numberOfBeers * 1.20;
            double priceOfChips = costOfBeers * 0.45;
            double costOfChips = Math.Ceiling(priceOfChips * numberOfChips);
            double totalPrice = costOfBeers + costOfChips;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {Math.Abs(totalPrice - budget):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(totalPrice - budget):f2} more leva!");
            }
        }
    }
}
