using System;

namespace _04.EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                bool isItEven = i % 2 == 0;
                if (isItEven)
                {
                    double c = Math.Pow(2, i);
                    Console.WriteLine(c);
                }
            }
        }
    }
}
