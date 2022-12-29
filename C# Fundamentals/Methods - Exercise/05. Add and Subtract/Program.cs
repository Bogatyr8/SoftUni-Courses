using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
//You will receive 3 integers. Create a method that returns the sum of the first two integers and another method that subtracts
//the third integer from the result of the sum method.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Extraction(Sum(a, b), c));
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Extraction(int a, int b)
        {
            return a - b;
        }
    }
}
