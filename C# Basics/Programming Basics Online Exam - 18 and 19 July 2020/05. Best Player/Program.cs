using System;

namespace _05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пепи иска да напишете програма, чрез която да разбере кой е най - добрият играч от световното първенство. Информацията, която получавате
            //ще бъде играч и колко гола е отбелязал. От вас се иска да отпечатате кой е играчът с най - много голове и дали е направил хет-трик.
            //Хеттрик е, когато футболистът е вкарал 3 или повече гола.Ако футболистът е вкарал 10 или повече гола, програмата трябва да спре.
            //Вход:
            //От конзолата се четат по два реда до въвеждане на команда "END":
            //•	Име на играч – текст
            //•	Брой вкарани голове  – цяло положително число в интервала[1 … 10000]
            //Изход:
            //На конзолата да се отпечатат 2 реда:
            //•	На първия ред:
            //"{име на играч} is the best player!"
            //•	На втория ред:
            //o Ако най - добрият футболист е направил хеттрик:
            //"He has scored {брой голове} goals and made a hat-trick !!!"
            //o Ако най - добрият футболист не е направил хеттрик:
            //"He has scored {брой голове} goals."
            string player = Console.ReadLine();
            string bestPlayer = String.Empty;
            int goals = 0;
            int maxGoals = int.MinValue;
            while (player != "END")
            {
                goals = int.Parse(Console.ReadLine());
                if (goals > 0)
                {
                    if (goals > maxGoals)
                    {
                        maxGoals = goals;
                        bestPlayer = player;
                    }
                    if (goals >= 10)
                    {
                        break;
                    }
                }
                player = Console.ReadLine();
            }
            if (goals >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {goals} goals.");
            }
        }
    }
}
