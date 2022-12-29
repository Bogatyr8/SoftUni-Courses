using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. Той обаче не знае колко парчета могат да си вземат
            //гостите от нея. Вашата задача е да напишете програма, която изчислява броя на парчетата, които гостите са взели, преди тя да
            //свърши. Ще получите размерите на тортата(широчина и дължина – цели числа в интервала[1...1000]) и след това на всеки ред, до
            //получаване на командата "STOP" или докато не свърши тортата, броят на парчетата, които гостите вземат от нея.
            //Бележка: Едно парче торта е с размер 1х1 см.
            //Да се отпечата на конзолата един от следните редове:
            //•	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
            //•	"No more cake left! You need {брой недостигащи парчета} pieces more."
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int numberOfPieces = length * width;
            int takenPieces = 0;
            string piecesTaken = string.Empty;
            bool doWeContinueGivingPieces = numberOfPieces > 0 || piecesTaken == "STOP";
            bool doWeHaveMorePieces = numberOfPieces > 0;
            bool doWeStop = piecesTaken == "STOP";
            while (doWeContinueGivingPieces)
            {

                piecesTaken = Console.ReadLine();
                doWeStop = piecesTaken == "STOP";
                if (doWeStop)
                {
                    Console.WriteLine($"{numberOfPieces} pieces are left.");
                    break;
                }
                else if (doWeHaveMorePieces)
                {
                    takenPieces = int.Parse(piecesTaken);
                    numberOfPieces -= takenPieces;
                }
                doWeContinueGivingPieces = numberOfPieces > 0 || piecesTaken == "STOP";
                doWeHaveMorePieces = numberOfPieces > 0;
            }
            if (!doWeStop)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(numberOfPieces)} pieces more.");
            }
        }
    }
}
