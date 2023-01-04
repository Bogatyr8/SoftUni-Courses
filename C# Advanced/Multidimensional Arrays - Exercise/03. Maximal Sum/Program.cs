namespace _3._Maximal_Sum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3
            //that has a maximal sum of its elements.
            //Input
            //•	On the first line, you will receive the rows N and columns M. On the next N lines, you will receive
            //each row with its columns.
            //Output
            //•	Print the elements of the 3 x 3 square as a matrix, along with their sum.
            string[] sizes = Console.ReadLine().Split();
            int n = int.Parse(sizes[0]);
            int m = int.Parse(sizes[1]);
            int[,] matrix = new int[n, m];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }
            int maxSum = int.MinValue;
            int[,] maxSub = new int[3, 3];
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = 0;
                    int[,] subMatrix = new int[3, 3] {
                        { matrix[row,col], matrix[row,col + 1], matrix[row,col + 2],},
                        { matrix[row + 1,col], matrix[row + 1,col + 1], matrix[row + 1,col + 2],},
                        { matrix[row + 2,col], matrix[row + 2,col + 1], matrix[row + 2,col + 2],}
                    };
                    foreach (var item in subMatrix)
                    {
                        currSum += item;
                    }
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSub = subMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{maxSub[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
