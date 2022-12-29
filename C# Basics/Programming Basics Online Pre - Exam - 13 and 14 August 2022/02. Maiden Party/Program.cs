using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
//Михаела държи сама да организира и заплати моминското си парти. Тя планува плащането да стане с приходите
//от онлайн магазина й.Да се напише програма, която пресмята печалбата от продажбите й.
//Цени на различните артикули:
//•	Любовно послание -0.60 лв.
//•	Восъчна роза -7.20 лв.
//•	Ключодържател - 3.60 лв.
//•	Карикатура - 18.20 лв.
//•	Късмет изненада -22 лв.
//Ако поръчаните артикули са 25 или повече магазинът прави отстъпка 35 % от общата цена. От спечелените
//пари Михаела трябва да предвиди и 10 % разход за хостинг. Да се пресметне дали парите ще й стигнат да
//си плати моминското парти.
//Вход
//От конзолата се четат 6 реда:
//1.Цена на моминското парти - реално число в интервала[1.00 … 10000.00]
//2.Брой любовни послания -цяло число в интервала[0… 1000]
//3.Брой восъчни рози -цяло число в интервала[0 … 1000]
//4.Брой ключодържатели - цяло число в интервала[0 … 1000]
//5.Брой карикатури - цяло число в интервала[0 … 1000]
//6.Брой късмети изненада -цяло число в интервала[0 … 1000]
//Изход
//На конзолата се отпечатва:
//•	Ако парите са достатъчни се отпечатва:
//o   "Yes! {оставащите пари} lv left."
//•	Ако парите НЕ са достатъчни се отпечатва:
//            o   "Not enough money! {недостигащите пари} lv needed."
//Резултатът трябва да се форматира до втория знак след десетичната запетая.
            double priceOfParty = double.Parse(Console.ReadLine());
            int loveWishes = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keyHolders = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckySurprice = int.Parse(Console.ReadLine());
            double income = loveWishes * 0.6 + waxRoses * 7.2 + keyHolders * 3.6 + caricatures * 18.2 + luckySurprice * 22;
            int numberOfOrders = loveWishes + waxRoses + keyHolders + caricatures + luckySurprice;
            if (numberOfOrders >= 25)
            {
                income -= income * 0.35;
                income -= income * 0.1;
            }
            else
            {

                income -= income * 0.1;
            }
            if (income >= priceOfParty)
            {
                Console.WriteLine($"Yes! {Math.Abs(income - priceOfParty):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(income - priceOfParty):f2} lv needed.");
            }
        }
    }
}
