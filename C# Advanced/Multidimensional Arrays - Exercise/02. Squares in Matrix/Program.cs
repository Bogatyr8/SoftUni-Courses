namespace _2._Squares_in_Matrix
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Find the count of 2 x 2 squares of equal chars in a matrix.
            //Input
            //•	On the first line, you are given the integers rows and cols – the matrix's dimensions.
            //•	Matrix characters come at the next rows lines(space separated).
            //Output
            //•	Print the number of all the squares matrixes you have found.
            string[] sizes = Console.ReadLine().Split();
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                }
            }

            int countEquals = 0;
            //scanning
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char[,] subMatrix = new char[2, 2] {
                        { matrix[row, col], matrix[row, col + 1] },
                        { matrix[row + 1, col], matrix[row + 1, col + 1] } };

                    bool isItEquals =
                        subMatrix[0, 0] == subMatrix[0, 1] &&
                        subMatrix[0, 0] == subMatrix[1, 0] &&
                        subMatrix[0, 0] == subMatrix[1, 1];

                    if (isItEquals)
                    {
                        countEquals++;
                    }
                }
            }
            Console.WriteLine(countEquals);
        }
    }
}
