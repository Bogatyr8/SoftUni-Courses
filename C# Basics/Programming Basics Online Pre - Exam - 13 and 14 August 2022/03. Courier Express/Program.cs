using System;

namespace _03._Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
//Куриерска фирма доставя пратки в цялата страна.
//За услуга тип "standard", срокът за доставка е 3 работни дни и фирмата калкулира цените при следните
//условия:
//•	За пратки по - леки от 1 кг – 3 стотинки на километър.
//•	От 1 кг до 10 кг – 5 стотинки на километър.
//•	От 10 кг вкл. до 40 кг – 10 стотинки на километър.
//•	От 40 кг вкл. до 90  кг – 15 стотинки на километър.
//•	От 90 кг вкл. до 150 кг – 20 стотинки на километър.
//За услуга тип "express", фирмата извършва услугата в рамките на 24 часа, като начислява надценка за
//всеки километър както следва: 
//•	За пратки по - леки от 1 кг – на килограм по 80 % от съответната цена на километър
//•	От 1 кг до 10  кг – на килограм по 40 % от съответната цена на километър
//•	От 10 кг вкл. до 40 кг – на килограм по 5 % от съответната цена на километър
//•	От 40 кг вкл. до 90  кг – на килограм по 2 % от съответната цена на километър
//•	От 90 кг вкл. до 150 кг – на килограм по 1 % от съответната цена на километър
//Напишете програма, която да пресмята при зададено разстояние в км. , тегло на пратката и вида услуга,
//каква ще бъде стойността за доставка на дадена пратка.
//Вход
//Входът се чете от конзолата и съдържа 3 реда:
//1.Тегло на пратката в килограми – реално число в интервала[0.01... 150.00]
//2.Тип услуга –  текст със следните възможности: "standard" или "express"
//3.Разстояние в километри – цяло число в интервала[1... 1000]
//Изход
//Да се отпечата на конзолата един ред:
//"The delivery of your shipment with weight of {тегло} kg. would cost {цена} lv."
//•	Теглото да бъде закръглено до третия знак след десетичната запетая
//•	Цената да бъде закръглена до втория знак след десетичната запетая
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double pricePerKilometer = 0;
            double priceBonus = 0;
            double finalPrice = 0;
            switch (type)
            {
                case "standard":
                    if (weight > 0 && weight < 1)
                    {
                        pricePerKilometer = 0.03;
                        priceBonus = 0;
                    }
                    if (weight >= 1 && weight < 10)
                    {
                        pricePerKilometer = 0.05;
                        priceBonus = 0;
                    }
                    if (weight >= 10 && weight < 40)
                    {
                        pricePerKilometer = 0.1;
                        priceBonus = 0;
                    }
                    if (weight >= 40 && weight < 90)
                    {
                        pricePerKilometer = 0.15;
                        priceBonus = 0;
                    }
                    if (weight >= 90 && weight < 150)
                    {
                        pricePerKilometer = 0.2;
                        priceBonus = 0;
                    }
                    break;
                case "express":
                    if (weight > 0 && weight < 1)
                    {
                        pricePerKilometer = 0.03;
                        priceBonus = 0.8;
                    }
                    if (weight >= 1 && weight < 10)
                    {
                        pricePerKilometer = 0.05;
                        priceBonus = 0.4;
                    }
                    if (weight >= 10 && weight < 40)
                    {
                        pricePerKilometer = 0.1;
                        priceBonus = 0.05;
                    }
                    if (weight >= 40 && weight < 90)
                    {
                        pricePerKilometer = 0.15;
                        priceBonus = 0.02;
                    }
                    if (weight >= 90 && weight < 150)
                    {
                        pricePerKilometer = 0.2;
                        priceBonus = 0.01;
                    }
                    break;
            }
            priceBonus *= pricePerKilometer;
            finalPrice = (distance * pricePerKilometer) + (priceBonus * weight * distance);
            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {finalPrice:f2} lv.");
        }
    }
}
