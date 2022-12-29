using System;

namespace _10._Diamond2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Подсказки:
//•	Всички редове съдържат точно по n символа.
//•	Първият ред съдържа отляво и отдясно точно leftRight = (n - 1) / 2 тирета.
//•	Всеки следващ ред до средния съдържа отляво и отдясно с 1 тире по-малко от предходния.
//•	Всеки следващ ред след средния съдържа отляво и отдясно с 1 тире повече от предходния.
//•	Всеки ред съдържа в средата си(във вътрешността на диаманта) mid = n - 2 * leftRight - 2 тирета.
//•	Всеки ред съдържа 2 звездички, освен когато mid е отрицателно(тогава има само 1 звездичка).
//•	За всеки ред може да се изчислят и отпечатат неговите 5 съставни части:
//o leftRight тиренца отляво
//o   1 звездичка
//o   mid тиренца в средата(когато mid >= 0)
//o   1 звездичка(когато mid >= 0)
//o   1 звездичка
//o   leftRight тиренца отляво

            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2) // top half
                {
                    for (int j = 1; j <= leftRight - i; j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= mid - (n - 2 * i); j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= leftRight - i; j++)
                    {
                        Console.Write("-");
                    }
                }
                else            // bottom half
                {
                    for (int j = 1; j <= leftRight - (n - 2 * i); j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= mid - (n - 2 * i); j++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= leftRight - (n - 2 * i); j++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
