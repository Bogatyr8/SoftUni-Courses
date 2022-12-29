using System;

namespace _04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лили вече е на N години. За всеки свой рожден ден тя получава подарък.
            //· За нечетните рождени дни(1, 3, 5...n) получава играчки.
            //· За четните рождени дни(2, 4, 6...n) получава пари.
            //За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден
            //(2-> 10, 4-> 20, 6-> 30...и т.н.). През годините Лили тайно е спестявала парите.Братът на Лили, в годините, които тя получава
            //пари, взима по 1.00 лев от тях.Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените
            //пари.С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат
            //да си купи пералня.
            //Вход
            //Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
            //· Възрастта на Лили - цяло число в интервала[1...77]
            //· Цената на пералнята - число в интервала[1.00...10 000.00]
            //· Единична цена на играчка -цяло число в интервала[0...40]
            //Изход
            //Да се отпечата на конзолата един ред:
            //· Ако парите на Лили са достатъчни:
            //o "Yes! {N}" - където N е остатъка пари след покупката
            //· Ако парите не са достатъчни:
            //o "No! {М}" - където M е сумата, която не достига
            //Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            int evenPresent = 0;
            int oddPresent = 0;
            int brotherFee = 1;
            for (int i = 1; i <= age; i++)
            {
                bool isItEvenAge = i % 2 == 0;
                if (isItEvenAge)
                {
                    evenPresent += (i / 2) * 10;
                    evenPresent -= brotherFee;
                }
                else
                {
                    oddPresent += priceOfToy;
                }
            }
            bool doesSheHaveTheMoney = (oddPresent + evenPresent) >= priceOfWashingMachine;
            if (doesSheHaveTheMoney)
            {
                Console.WriteLine($"Yes! {Math.Abs((oddPresent + evenPresent) - priceOfWashingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs((oddPresent + evenPresent) - priceOfWashingMachine):f2}");
            }
        }
    }
}
