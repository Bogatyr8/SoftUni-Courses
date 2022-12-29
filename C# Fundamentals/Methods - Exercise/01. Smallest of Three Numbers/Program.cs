using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that prints out the smallest of three integer numbers.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Smallestnumer(a, b, c);
        }

        private static void Smallestnumer(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        }
    }
}
