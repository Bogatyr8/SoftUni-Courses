namespace _04._Symbol_in_Matrix
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads N, a number representing rows and cols of a matrix. On the next N lines, you
//will receive rows of the matrix.Each row consists of ASCII characters. After that, you will receive a
//symbol. Find the first occurrence of that symbol in the matrix and print its position in the format:
//"({row}, {col})".If there is no such symbol, print an error message "{symbol} does not occur in the
//matrix".
            int n = int.Parse(Console.ReadLine());
            char[,] sqMatrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                char[] colElem = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    sqMatrix[row, col] = colElem[col];
                }
            }

            char seekChar = char.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (sqMatrix[row, col] == seekChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{seekChar} does not occur in the matrix");
        }
    }
}
