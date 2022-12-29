using System;

namespace _04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            //В кутия имаме неопределен брой топки с различни цветове, които ни носят различен брой точки. Задачата ни е да извадим Х бр.топки, които
            //ще бъдат въведени от конзолата, като се има в предвид, че всеки различен цвят влияе на точките ни по следния начин:
            //•	Ако топката е “red” точките ни се повишават с 5.
            //•	Ако топката е “orange” точките ни се повишават с 10.
            //•	Ако топката е “yellow” точките ни се повишават с 15.
            //•	Ако топката е “white” точките ни се повишават с 20.
            //•	Ако топката е “black” точките ни се делят на 2, като закръгляме към по-малкото цяло число.
            //Ако топката е с какъвто и да е цвят, различен от по - горните, точките не се манипулират и програмата продължава да работи.
            //Вход:
            //1.От конзолата се чете 1 цяло число N, което е броят на топките в диапазон(0 - 1000).
            //2.След това се четат N на брой цветове.
            //Изход:
            //Отпечатват се следните редове:
            //"Total points: {всичките събрани точки}"
            //"Red balls: {броят червени топки}"
            //"Orange balls: {броят оранжеви топки}"
            //"Yellow balls: {броят жълти топки}"
            //"White balls: {броят бели топки}"
            //"Other colors picked: {броят на избраните топки извън зададените цветове}"
            //"Divides from black balls: {броят на пътите, в които точките са били разделяни на 2}"
            int number = int.Parse(Console.ReadLine());
            int counterRed = 0;
            int counterOrange = 0;
            int counterYellow = 0;
            int counterWhite = 0;
            int counterOther = 0;
            int counterBlack = 0;
            double points = 0;
            for (int i = 0; i < number; i++)
            {
                string ballColor = Console.ReadLine();
                switch (ballColor)
                {
                    case "red":
                        points += 5;
                        counterRed++;
                            break;
                    case "orange":
                        points += 10;
                        counterOrange++;
                        break;
                    case "yellow":
                        points += 15;
                        counterYellow++;
                        break;
                    case "white":
                        points += 20;
                        counterWhite++;
                        break;
                    case "black":
                        points /= 2;
                        counterBlack++;
                        break;
                    default:
                        counterOther++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {counterRed}");
            Console.WriteLine($"Orange balls: {counterOrange}");
            Console.WriteLine($"Yellow balls: {counterYellow}");
            Console.WriteLine($"White balls: {counterWhite}");
            Console.WriteLine($"Other colors picked: {counterOther}");
            Console.WriteLine($"Divides from black balls: {counterBlack}");
        }
    }
}