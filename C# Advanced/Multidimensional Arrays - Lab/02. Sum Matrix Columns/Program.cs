namespace _02._Sum_Matrix_Columns
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads a matrix from the console and prints the sum for each column. On the first
//line, you will get matrix rows. On the next rows lines, you will get elements for each column separated
//with a space. 
            int[] dimension = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElem = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElem[col];
                }
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
