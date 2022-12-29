using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int comboCounter = 0;
            bool flag = false;
            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    comboCounter++;
                    if ((i + j) == magicNumber)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{comboCounter} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{comboCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
