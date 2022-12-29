using System;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bool isNumberLessThan200 = number < 200;
                bool isNumberBetween200and399 = number >= 200 && number < 400;
                bool isNumberBetween400and599 = number >= 400 && number < 600;
                bool isNumberBetween600and799 = number >= 600 && number < 800;
                bool isNumberAbove800 = number >= 800;
                if (isNumberLessThan200)
                {
                    p1++;
                }
                else if (isNumberBetween200and399)
                {
                    p2++;
                }
                else if (isNumberBetween400and599)
                {
                    p3++;
                }
                else if (isNumberBetween600and799)
                {
                    p4++;
                }
                else if (isNumberAbove800)
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(((double)p1 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)p2 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)p3 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)p4 / n) * 100):f2}%");
            Console.WriteLine($"{(((double)p5 / n) * 100):f2}%");
        }
    }
}
