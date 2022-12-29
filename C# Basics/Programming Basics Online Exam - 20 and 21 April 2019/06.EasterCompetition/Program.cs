using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            //С наближаването на Великден, пекарна организира конкурс за направата на най-хубав козунак.Напишете програма, която да намира сладкаря с
            //най - висок резултат.В началото на конкурса се въвежда броя на козунаците, които ще бъдат дегустирани от посетителите на пекарната, като за
            //всеки козунак различен брой посетители, ще дадат оценка от 1 до 10.
            //Вход
            //Първоначално от конзолата се прочита броя на козунаците – цяло число в интервала[1… 100]
            //След това за всеки козунак се прочита:
            //•	Името на пекаря, който е направил козунака – текст
            //•	До получаване на командата "Stop" се прочита
            //o оценка за козунак от един човек  – цяло число в интервала[1... 10]
            //Изход
            //След получаване на командата "Stop" се печата един ред:
            //•	"{името на пекаря} has {общият брой получени точки} points."
            //Ако след командата "Stop", пекарят е с най-много точки до момента, да се отпечата допълнителен ред:
            //•	"{името на пекаря} is the new number 1!"
            //След дегустация на всички козунаци, да се отпечата един ред:
            //•	"{името на пекаря с най-много точки} won competition with {точките на пекаря} points!"
            int numberOfBakers = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string bestBaker = string.Empty;
            for (int i = 1; i <= numberOfBakers; i++)
            {
                int totalPoints = 0;
                string nameOfBaker = Console.ReadLine();
                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    int points = int.Parse(input);
                    totalPoints += points;
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{nameOfBaker} has {totalPoints} points.");
                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bestBaker = nameOfBaker;
                    Console.WriteLine($"{bestBaker} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestBaker} won competition with {maxPoints} points!");
        }
    }
}
