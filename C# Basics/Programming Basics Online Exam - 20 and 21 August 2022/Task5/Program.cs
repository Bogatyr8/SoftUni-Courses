using System;

namespace _05ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Коледа наближава и Иван решава да купи по един подарък за всеки от семейството си.Той си прави списък с хората, на които иска да подари нещо.Това, какъв подарък ще купи зависи от възрастта на хората в списъка му:
            //•	Всички до 16(вкл.) години се считат за деца и ще получат играчка
            //•	Всички над 16 години се считат за възрастни и ще получат коледен пуловер
            //•	Цената на всяка играчка е 5 лв., а цената на един пуловер е 15 лв.
            //Напишете програма, която пресмята колко души от семейството на Иван са до 16(вкл.) години и колко са над тази възраст, също и колко пари ще струват подаръците на децата и възрастните.
            //Вход:
            //От конзолата се четат поредица от редове до получаване на команда "Christmas":
            //•	Годините на всеки член от семейството -цяло число в интервала[1 … 130]
            //Изход:
            //Да се отпечатат на конзолата четири реда:
            //•	"Number of adults: {брой хора над 16 години}"
            //•	"Number of kids: {брой хора до 16 (вкл.) години}"
            //•	"Money for toys: {сумата за всички играчки}"
            //•	"Money for sweaters: {сума за всички пуловери}"

            string input = Console.ReadLine();
            int counterChild = 0;
            int counterAdult = 0;
            while (input != "Christmas")
            {
                int age = int.Parse(input);
                if (age <= 16)
                {
                    counterChild++;
                }
                else
                {
                    counterAdult++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Number of adults: {counterAdult}");
            Console.WriteLine($"Number of kids: {counterChild}");
            Console.WriteLine($"Money for toys: {counterChild * 5}");
            Console.WriteLine($"Money for sweaters: {counterAdult * 15}");
        }
    }
}
