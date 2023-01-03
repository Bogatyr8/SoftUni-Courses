namespace _07._Pascal_Triangle
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//The Pascal’s triangle may be constructed in the following manner: in row 0(the topmost row), there is a
//unique nonzero entry 1.Each entry of each subsequent row is constructed by adding the number above and
//to the left with the number above and to the right, treating blank entries as 0.
//Write a program to print the Pascal’s triangle of given size n.
            long n = long.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];
            long column = 1;
            pascal[0] = new long[1];
            pascal[0][0] = 1;
            for (int row = 1; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    pascal[row][col] = pascal[row - 1][col - 1] + pascal[row - 1][col];
                }
                pascal[row][pascal[row].Length - 1] = 1;
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(String.Join(" ", pascal[row]));
            }
        }
    }
}
