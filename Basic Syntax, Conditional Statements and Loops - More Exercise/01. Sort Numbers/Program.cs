using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = 0;
            int middle = 0;
            int min = 0;
            if (a > b && a > c)
            {
                max = a;
                if (b >= c)
                {
                    middle = b;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = b;
                }
            }
            else if (b > a && b > c)
            {
                max = b;
                if (a > c)
                {
                    middle = a;
                    min = c;
                }
                else
                {
                    middle = c;
                    min = a;
                }
            }
            else if (c > a && c > b)
            {
                max = c;
                if (a > b)
                {
                    middle = a;
                    min = b;
                }
                else
                {
                    middle = b;
                    min = a;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
