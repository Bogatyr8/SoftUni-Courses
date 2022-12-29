using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която изчислява колко решения в естествените числа(включително и нулата) има уравнението:
            //x1 + x2 + x3 = n
            //Числото n е цяло число и се въвежда от конзолата. 
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n; y++)
                {
                    for (int z = 0; z <= n; z++)
                    {
                        sum = x + y + z;
                        if (sum == n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
