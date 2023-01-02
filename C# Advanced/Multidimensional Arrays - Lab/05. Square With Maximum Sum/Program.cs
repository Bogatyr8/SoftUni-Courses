namespace _05._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads a matrix from the console. Then find the biggest sum of the 2x2 submatrix
//and print it to the console.
//On the first line, you will get matrix sizes in format rows, columns.
//On the next rows lines, you will get elements for each column, separated with a comma and a space.
//Print the biggest top - left square, which you find, and the sum of its elements.
            int[] dimensions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int maxSum = int.MinValue;
            int subMatrixRow = 0;
            int subMatrixCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int curSum = 0;
                    curSum += matrix[row, col];
                    curSum += matrix[row, col + 1];
                    curSum += matrix[row + 1, col];
                    curSum += matrix[row + 1, col + 1];
                    if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        subMatrixRow = row;
                        subMatrixCol = col;
                    }
                }
            }
            for (int subRow = 0; subRow < 2; subRow++)
            {
                for (int subCol = 0; subCol < 2; subCol++)
                {
                    Console.Write($"{matrix[subMatrixRow + subRow, subMatrixCol + subCol]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
