namespace _04._Matrix_Shuffling
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//Write a program that reads a string matrix from the console and performs certain operations with its
//elements. User input is provided in a similar way as in the problems above – first, you read the
//dimensions and then the data. 
//Your program should then receive commands in the format: "swap row1 col1 row2 col2" where row1, col1,
//row2, col2 are coordinates in the matrix. For a command to be valid, it should start with the "swap"
//keyword along with four valid coordinates(no more, no less). You should swap the values at the given
//coordinates(cell[row1, col1] with cell[row2, col2]) and print the matrix at each step(thus you'll be
//able to check if the operation was performed correctly). 
//If the command is not valid(doesn't contain the keyword "swap", has fewer or more coordinates entered
//or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your
//program should finish when the string "END" is entered.
            string[] sizes = Console.ReadLine().Split();
            int n = int.Parse(sizes[0]);
            int m = int.Parse(sizes[1]);
            string[,] matrix = new string[n, m];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                string[] input = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                if (command != "swap" ||  input.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (command == "swap")
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);
                    if (row1 < 0 || row1 > matrix.GetLength(0) ||
                        col1 < 0 || col1 > matrix.GetLength(1) ||
                        row2 < 0 || row2 > matrix.GetLength(0) ||
                        col2 < 0 || col2 > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    PrintMatrix(matrix);
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
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
