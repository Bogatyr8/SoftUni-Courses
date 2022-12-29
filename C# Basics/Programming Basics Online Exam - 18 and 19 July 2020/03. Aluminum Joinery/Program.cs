using System;

namespace _03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
//Фирма - производител на алуминиева дограма приема поръчки за изработката и монтаж със следния ценоразпис за един брой.Фирмата приема само
//поръчки на едро(над 10 бр.). В зависимост от поръчания брой дограми, фирмата прави различна отстъпка на своите клиенти.
//Фирмата предлага също и доставка на поръчките си срещу 60 лв.
            //  Размер          Единична цена           Отстъпка от цената
            //  90X130          110 лв.                 Над 30 броя – 5 %
            //                                          Над 60 броя – 8 %
            //  100X150         140 лв.                 Над 40 броя – 6 %
            //                                          Над 80 броя – 10 %
            //  130X180         190 лв.                 Над 20 броя – 7 %
            //                                          Над 50 броя – 12 %
            //  200X300         250 лв.                 Над 25 броя – 9 %
            //                                          Над 50 броя – 14 %
//Ако поръчката надвишава 99 броя  – върху крайната цена се начисляват допълнителни 4 % отстъпка(след като се начисли цената за доставка,
//ако има такава).
//При поръчка под 10 бр.на конзолата да бъде изписано "Invalid order"
//Вход:
//Потребителят въвежда 3 реда:
//1.Брой дограми – цяло число в интервала[0..1000];
//2.Вид на дограмите – текст "90X130" или "100X150" или "130X180" или "200X300";
//3.Начин на получаване – текст
//•	С доставка -"With delivery"
//•	Без доставка -"Without delivery"
//Изход:
//Извежда се едно число – стойността на поръчката, в следния формат:
//o   "{Обща стойност на поръчката} BGN"
//Резултатът да се форматира до втори знак след десетичната запетая.
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string deliveryType = Console.ReadLine();
            double discount = 0;
            double pricePerPiece = 0;
            double totalPrice = 0;
            if (number < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                switch (type)
                {
                    case "90X130":
                        pricePerPiece = 110;
                        totalPrice = pricePerPiece * number;
                        if (number > 60)
                        {
                            totalPrice *= 0.92;
                        }
                        else if (number > 30)
                        {
                            totalPrice *= 0.95;
                        }
                        break;
                    case "100X150":
                        pricePerPiece = 140;
                        totalPrice = pricePerPiece * number;
                        if (number > 80)
                        {
                            totalPrice *= 0.90;
                        }
                        else if (number > 40)
                        {
                            totalPrice *= 0.94;
                        }
                        break;
                    case "130X180":
                        pricePerPiece = 190;
                        totalPrice = pricePerPiece * number;
                        if (number > 50)
                        {
                            totalPrice *= 0.88;
                        }
                        else if (number > 20)
                        {
                            totalPrice *= 0.93;
                        }
                        break;
                    case "200X300":
                        pricePerPiece = 250;
                        totalPrice = pricePerPiece * number;
                        if (number > 50)
                        {
                            totalPrice *= 0.86;
                        }
                        else if (number > 25)
                        {
                            totalPrice *= 0.91;
                        }
                        break;
                }
                switch (deliveryType)
                {
                    case "With delivery":
                        totalPrice += 60;
                        break;
                    case "Without delivery":
                        totalPrice += 0;
                        break;
                }
                if (number > 99)
                {
                    totalPrice *= 0.96;
                }
                Console.WriteLine($"{totalPrice:f2} BGN");
            }
        }
    }
}
