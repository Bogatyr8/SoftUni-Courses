using System;

namespace _08._Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
//Напишете програма, която чете цяло число n (3 ≤ n ≤ 100), въведено от потребителя, и печата слънчеви очила с размер 5*n x n като в примерите:
//Подсказки:
//•	Отпечатайте най-горния ред от очилата:
//o   2 * n звездички; n интервала; 2 * n звездички
//•	Отпечатайте средните n - 2 реда:
//o звездичка; 2 * n - 2 наклонени черти; звездичка; n интервала; звездичка; 2 * n - 2 наклонени черти; звездичка
//o   когато редът е(n - 1) / 2 - 1, печатайте n вертикални черти вместо n интервала
//•	Отпечатайте най-долния ред от очилата:
//o   2 * n звездички; n интервала; 2 * n звездички

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n; i++)             // top row
            {
                Console.Write("*");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();                        // top row
            for (int i = 1; i <= n - 2; i++)             // middle rows
            {
                if (i != (n - 1) / 2) // normal middle
                {
                    Console.Write("*");
                    for (int j = 1; j <= 2 * n - 2; j++)            
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= 2 * n - 2; j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    Console.WriteLine();                        
                }                                   // normal middle
                else if (i == (n - 1) / 2)    // frame middle row
                {
                    Console.Write("*");
                    for (int j = 1; j <= 2 * n - 2; j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("|");
                    }
                    Console.Write("*");
                    for (int j = 1; j <= 2 * n - 2; j++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }                                         // frame middle row
            }                                           // middle rows
            for (int i = 1; i <= 2 * n; i++)             // bottom row
            {
                Console.Write("*");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" ");
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();                        // bottom row
        }
    }
}
