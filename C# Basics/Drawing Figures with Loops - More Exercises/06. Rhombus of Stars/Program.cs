using System;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло положително число n, въведено от потребителя, и печата ромбче от звездички с размер n,
            //като в примерите по-долу:
            //•	Разделете ромба на горна и долна част и ги печатайте с два отделни цикъла.
            //•	За горната част завъртете цикъл за row от 1 то n:
            //o Отпечатайте n - row интервала.
            //o Отпечатайте “*”.
            //o Отпечатайте row - 1 пъти “ *”.
            //•	Долната част отпечатайте аналогично на горната с цикъл от 1 до n-1.
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)            // top part
            {
                for (int j1 = 0; j1 < n - i; j1++)
                {
                    Console.Write(" ");
                }

                for (int j2 = 0; j2 < i; j2++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }                   //-------------------- top part
            for (int i = 1; i <= n - 1; i++)            // bottom part
            {
                for (int j3 = 0; j3 < i; j3++)
                {
                    Console.Write(" ");
                }

                for (int j4 = 0; j4 < n - i; j4++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }                   //-------------------- bottom part
        }
    }
}
