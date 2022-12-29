using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лято е с много променливо време и Виктор има нужда от вашата помощ.Напишете програма която спрямо времето от денонощието и
            //градусите да препоръча на Виктор какви дрехи да си облече. Вашия приятел има различни планове за всеки етап от деня, които
            //изискват и различен външен вид, тях може да видите от таблицата.
            //От конзолата се четат точно два реда:
            //· Градусите - цяло число в интервала[10…42]

            //· Текст, време от денонощието - с възможности - "Morning", "Afternoon", "Evening"
            //Време от денонощието / градуси        Мorning                      Afternoon                              Evening

            //10 <= градуси <= 18      Outfit = Sweatshirt Shoes = Sneakers     Outfit = Shirt Shoes = Moccasins Outfit = Shirt Shoes = Moccasins

            //18 < градуси <= 24 Outfit = Shirt Shoes = Moccasins Outfit = T - Shirt Shoes = Sandals Outfit = Shirt Shoes = Moccasins

            //градуси >= 25 Outfit = T - Shirt Shoes = Sandals Outfit = Swim Suit Shoes = Barefoot Outfit = Shirt Shoes = Moccasins
            //Да се отпечата на конзолата на един ред: "It's {градуси} degrees, get your {облекло} and {обувки}.
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (temperature >= 10 && temperature <= 18)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (temperature >= 25)
            {
                switch (time)
                {
                    case "Morning":
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}
