namespace _08._Bombs
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
//You will be given a square matrix of integers, each integer separated by a single space and each row on
//a new line.Then on the last line of input, you will receive indexes - coordinates to several cells
//separated by a single space, in the following format: row1,column1 row2, column2 row3,column3 … 
//On those cells there are bombs. You have to proceed with every bomb, one by one in the order they were
//given.When a bomb explodes deals damage equal to its integer value, to all the cells around it(in every
//direction and all diagonals). One bomb can't explode more than once and after it does, its value becomes
//0. When a cell's value reaches 0 or below, it dies.Dead cells can't explode.
//You must print the count of all alive cells and their sum. Afterward, print the matrix with all of its
//cells(including the dead ones). 
//Input
//•	On the first line, you are given the integer N – the size of the square matrix.
//•	The next N lines hold the values for every row – N numbers separated by a space.
//•	On the last line, you will receive the coordinates of the cells with the bombs in the format
//described above.
//Output
//•	On the first line, you need to print the count of all alive cells in the format: 
//"Alive cells: {aliveCells}"
//•	On the second line, you need to print the sum of all alive cells in the format: 
//"Sum: {sumOfCells}"
//•	At the end print the matrix.The cells must be separated by a single space.
//Constraints
//•	The size of the matrix will be between[0…1000].
//•	The bomb coordinates will always be in the matrix.
//•	The bomb's values will always be greater than 0.
//•	The integers of the matrix will be in the range[1…10000].
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Initiallize(n, matrix);
            char[] separators = new char[2] { ' ', ',' };
            int[] bombs = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0, j = 1; i < bombs.Length - 1; i += 2, j += 2)
            {
                int bombRow = bombs[i];
                int bombCol = bombs[j];
                Explosion(bombRow, bombCol, matrix);
            }
            int sum = 0;
            int aliveCells = 0;
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    sum += item;
                    aliveCells++;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }

        private static void Explosion(int bombRow, int bombCol, int[,] matrix)
        {
            if (matrix[bombRow, bombCol] <= 0)
            {
                return;
            }

            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {
                    int rowCheck = bombRow + r;
                    int colCheck = bombCol + c;
                    if ((rowCheck < 0 || colCheck < 0 ||
                        rowCheck >= matrix.GetLength(1) || 
                        colCheck >= matrix.GetLength(1) ||
                        matrix[rowCheck, colCheck] <= 0) ||
                        (rowCheck == bombRow && colCheck == bombCol))
                    {
                        continue;
                    }
                    else
                    {
                        matrix[rowCheck, colCheck] -= matrix[bombRow, bombCol];
                    }
                }
            }

            matrix[bombRow, bombCol] = 0;
        }

        private static void Initiallize(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
