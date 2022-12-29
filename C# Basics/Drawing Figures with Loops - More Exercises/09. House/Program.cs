using System;

namespace _09._House
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете число n (2 ≤ n ≤ 100), въведено от потребителя, и печата къщичка с размер n x n:
            //        Подсказки:
            //•	Отпечатайте в цикъл покрива на къщичката:
            //o Той съдържа(n + 1) / 2 реда.
            //o На първия си ред съдържа 1 звездичка при нечетно n или 2 звездички при четно n.
            //o На всеки следващ ред съдържа с 2 звездички повече.
            //•	Отпечатайте в цикъл основата на къщичката: n / 2 - 1 реда.
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)                             // Roof   (n = Even)
            {
                for (int i = 1; i <= (n + 1) / 2; i++)
                {
                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 1; j <= n / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
            else                                        // Roof   (n = Odd)
            {
                for (int i = 1; i <= (n + 1) / 2; i++)
                {
                    for (int j = 1; j <= (n + 1) / 2 -i; j++)
                    {
                        Console.Write("-");
                    }
                    if (i == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        for (int j = 1; j <= 2 * i - 1; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    for (int j = 1; j <= (n + 1) / 2 - i; j++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < n / 2; i++)             // Main body
            {
                Console.Write("|");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
