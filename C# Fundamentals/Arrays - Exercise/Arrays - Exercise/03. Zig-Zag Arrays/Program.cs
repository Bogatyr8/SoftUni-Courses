using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that creates 2 arrays.You will be given an integer n.On the next n lines, you will get 2 integers.Form 2 new arrays in a zig-zag pattern as shown below.
            int n = int.Parse(Console.ReadLine());
            int[] output1 = new int[n];
            int[] output2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    output1[i] = input[0];
                    output2[i] = input[1];
                }
                else
                {
                    output2[i] = input[0];
                    output1[i] = input[1];
                }
            }
            Console.WriteLine(string.Join(" ", output1));
            Console.WriteLine(string.Join(" ", output2));

        }
    }
}
