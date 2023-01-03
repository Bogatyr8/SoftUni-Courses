namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a matrix from the console. On the first line, you will get matrix rows. On
            //the next rows lines, you will get elements for each column separated with space.You will be receiving
            //commands in the following format:
            //•	Add { row} { col} { value} – Increase the number at the given coordinates with the value.
            //•	Subtract { row} { col} { value} – Decrease the number at the given coordinates by the value.
            //Coordinates might be invalid. In this case, you should print "Invalid coordinates".When you receive
            //"END" you should print the matrix and stop the program.
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int row = 0; row < jagged.Length; row++)
            {
                int[] line = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = line;
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = line[col];
                }
            }
            string input;
            while ((input = Console.ReadLine()).ToLower() != "end")
            {
                string[] commArgs = input.Split();
                string command = commArgs[0];
                int row = int.Parse(commArgs[1]);
                int col = int.Parse(commArgs[2]);
                int value = int.Parse(commArgs[3]);
                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command.ToLower() == "add")
                {
                    jagged[row][col] += value;
                }
                else if (command.ToLower() == "subtract")
                {
                    jagged[row][col] -= value;
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jagged[row]));
            }
        }
    }
}
