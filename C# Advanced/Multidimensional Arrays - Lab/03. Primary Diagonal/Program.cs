namespace _3._Primary_Diagonal
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that finds the sum of elements from the matrix’s primary diagonal.
            //Input
            //•	On the first line, you are given the integer N – the size of the square matrix.
            //•	The next N lines, hold the values for every row – N numbers separated by a space.
            int n = int.Parse(Console.ReadLine());
            int[,] sqMatrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] colEl = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    sqMatrix[row, col] = colEl[col];
                }
            }
            int sumPrimeryDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                sumPrimeryDiagonal += sqMatrix[i, i];
            }
            Console.WriteLine(sumPrimeryDiagonal);
        }
    }
}
