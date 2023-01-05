namespace _05._Snake_Moves
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//You are walking in the park and you encounter a snake! You are terrified and you start running zig-zag,
//so the snake starts following you. 
//You have a task to visualize the snake's path in a square form. A snake is represented by a string. The
//isle is a rectangular matrix of size N x M. A snake starts going down from the top-left corner and
//slithers its way down. The first cell is filled with the first symbol of the snake, the second cell is
//filled with the second symbol, etc. The snake is as long as it takes to fill the stairs– if you reach
//the end of the string representing the snake, start again at the beginning. After you fill the matrix
//with the snake's path, you should print it.
//Input
//•	The input data should be read from the console.It consists of exactly two lines.
//•	On the first line, you'll receive the dimensions of the stairs in the format: "N M", where N is the
//number of rows, and M is the number of columns. They'll be separated by a single space.
//•	On the second line, you'll receive the string representing the snake.
//Output
//•	The output should be printed on the console. It should consist of N lines.
//•	Each line should contain a string representing the respective row of the matrix.
//Constraints
//•	The dimensions N and M of the matrix will be integers in the range[1…12],
//•	The snake will be a string with length in the range[1…20] and will not contain any whitespace
//characters.
            string[] sizes = Console.ReadLine().Split();
            int n = int.Parse(sizes[0]);
            int m = int.Parse(sizes[1]);
            char[,] matrix = new char[n, m];
            char[] input = Console.ReadLine().ToCharArray();
            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = input[index];
                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = input[index];
                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
