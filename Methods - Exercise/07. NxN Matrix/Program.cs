using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a method that receives a single integer n and prints an NxN matrix using this number as a filler.
            int n = int.Parse(Console.ReadLine());

            NxNMatrix(n);

        }

        static void NxNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
