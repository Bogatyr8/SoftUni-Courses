using System;

namespace _07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
//Напишете програма, която чете число n (1 ≤ n ≤ 100), въведено от потребителя, и печата коледна елха с размер n като в примерите по-долу:
//Подсказки: 
//•	В цикъл за i от 0 до n печатайте(за лявата част на елхата):
//o n-i интервала; n звездички; вертикална черта.
//•	Аналогично довършете дясната част на елхата.
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
