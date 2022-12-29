using System;

namespace _05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
//Напишете програма, която чете цяло положително число n, въведено от потребителя, и чертае на конзолата квадратна рамка с размер
//n * n като в примерите по-долу:
//        Подсказки:
//•	Отпечатайте горната част: знак “+”, n - 2 пъти знак “-”, знак “+”.
//•	Отпечатайте средната част: в цикъл n - 2 пъти печатайте знак “|”, n - 2 пъти знак “-”, знак “|”.
//•	Отпечатайте долната част: знак “+”, n - 2 пъти знак “-”, знак “+”.
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");             // top row
            if (n > 2)
            {
                for (int j = 1; j <= (n - 2); j++)
                {
                    Console.Write("- ");
                }
            }
            Console.Write("+");
            Console.WriteLine();            // top row

            if (n > 2)                      // middle rows
            {
                for (int i = 1; i <= n - 2; i++)   
                {
                    Console.Write("| ");
                    if (n > 2)
                    {
                        for (int j = 1; j <= (n - 2); j++)
                        {
                            Console.Write("- ");
                        }
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }                               // middle rows

            Console.Write("+ "); // bottom row
            if (n > 2)
            {
                for (int j = 1; j <= (n - 2); j++)
                {
                    Console.Write("- ");
                }
            }
            Console.Write("+");             // bottom row
        }
    }
}
