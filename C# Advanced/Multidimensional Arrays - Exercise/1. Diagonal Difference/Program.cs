namespace _1._Diagonal_Difference
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that finds the difference between the sums of the square matrix diagonals(absolute value).
//Input
//•	On the first line, you are given the integer N – the size of the square matrix.
//•	The next N lines, hold the values for every row – N numbers separated by a space.
//Output
//•	Print the absolute difference between the sums of the primary and the secondary diagonal.
//Hint
//•	Use a single loop i = [1 … n] to sum the diagonals.
//•	The primary diagonal holds all cells { row, col} where row == col == i.
//•	The secondary diagonal holds all cells { row, col} where row == i and col == n - 1 - i.
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }
            //Sum the diagonals
            int primaryD = 0;
            int secondaryD = 0;
            for (int i = 0; i < n; i++)
            {
                primaryD += matrix[i, i];
                secondaryD += matrix[i, n - 1 - i];
            }
            Console.WriteLine(Math.Abs(primaryD - secondaryD));
        }
    }
}
