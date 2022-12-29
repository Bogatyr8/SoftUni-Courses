using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //На осемнадесетия си рожден ден на Хосе взел решение, че ще се изнесе да живее на квартира. Опаковал багажа си в кашони и
            //намерил подходяща обява за апартамент под наем.Той започва да пренася своя багаж на части, защото не може да пренесе целия
            //наведнъж. Има ограничено свободно пространство в новото си жилище, където може да разположи вещите, така че мястото да бъде
            //подходящо за живеене.
            //Напишете програма, която изчислява свободния обем от жилището на Хосе, който остава след като пренесе багажа си.
            //Бележка: Един кашон е с точни размери:  1m.x 1m.x 1m.
            //Вход
            //Потребителят въвежда следните данни на отделни редове:
            //1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            //4.На следващите редове(до получаване на команда "Done") -брой кашони, които се пренасят в квартирата - цяло число в
            //интервала[1...10000]
            //Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
            //Изход
            //Да се отпечата на конзолата един от следните редове:
            //•	Ако стигнете до командата "Done" и има още свободно място:
            //"{брой свободни куб. метри} Cubic meters left."
            //•	Ако свободното място свърши преди да е дошла команда "Done":
            //"No more free space! You need {брой недостигащи куб. метри} Cubic meters more."
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalVolume = length * width * height;
            int occupiedVolume = 0;
            string input = string.Empty;
            int inputVolume = 0;
            bool areWeDone = input == "Done";
            bool doWePutMoreBoxes = (totalVolume - occupiedVolume) > 0;
            while (doWePutMoreBoxes)
            {
                input = Console.ReadLine();
                areWeDone = input == "Done";
                if (areWeDone)
                {
                    Console.WriteLine($"{Math.Abs(totalVolume - occupiedVolume)} Cubic meters left.");
                    break;
                }
                inputVolume = int.Parse(input);
                occupiedVolume += inputVolume;
                doWePutMoreBoxes = (totalVolume - occupiedVolume) > 0;
            }
            if (!areWeDone)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(totalVolume - occupiedVolume)} Cubic meters more.");
            }
        }
    }
}
