using System;

namespace Test1_Task10_RowOfPosNegNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int positive = 0;
            int negative = -1;
            for (int i = 0; i < 99; i++)
            {
                if (i % 2 == 0)
                {
                    positive += 2;
                    Console.WriteLine(positive);
                }
                else
                {
                    negative -= 2;
                    Console.WriteLine(negative);
                }
            }
        }
    }
}
