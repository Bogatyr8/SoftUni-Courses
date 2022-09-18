using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int treshold = int.Parse(Console.ReadLine());
            int times = treshold;
            do
            {
                    Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                times++;
            }
            while (times <= 10);
        }
    }
}
