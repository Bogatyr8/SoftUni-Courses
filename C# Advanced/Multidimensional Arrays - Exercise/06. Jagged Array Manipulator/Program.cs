namespace _6._Jagged_Array_Manipulator
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that populates, analyzes and manipulates the elements of a matrix with an unequal
            //length of its rows.
            //First, you will receive an integer N equal to the number of rows in your matrix.
            //On the next N lines, you will receive sequences of integers, separated by a single space. Each sequence
            //is a row in the matrix.
            //After populating the matrix, start analyzing it. If a row and the one below it have equal length,
            //multiply each element in both of them by 2, otherwise - divide by 2.
            //Then, you will receive commands. There are three possible commands:
            //•	"Add {row} {column} {value}" - add { value} to the element at the given indexes, if they are valid.
            //•	"Subtract {row} {column} {value}" - subtract { value} from the element at the given indexes,
            //if they are valid.
            //•	"End" - print the final state of the matrix(all elements separated by a single space) and stop the
            //program.
            //Input
            //•	On the first line, you will receive the number of rows of the matrix - integer N.
            //•	On the next N lines, you will receive each row – sequence of integers, separated by a single space
            //•	{ value}
            //            will always be an integer number.
            //•	Then you will be receiving commands until reading "End".
            //Output
            //•	The output should be printed on the console and it should consist of N lines.
            //•	Each line should contain a string representing the respective row of the final matrix, elements
            //separated by a single space.
            //Constraints
            //•	The number of rows N of the matrix will be an integer in the range[2…12].
            //•	The input will always follow the format above.
            //•	Think about data types. 
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            Initiallize(n, jagged);
            AnalizeThis(n, jagged);
            Modify(n, jagged);
            Print(jagged);
        }

        private static void Print(int[][] jagged)
        {
            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        private static void Modify(int n, int[][] jagged)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                string[] input = inputLine.Split();
                string command = input[0];
                int row1 = int.Parse(input[1]);
                int col1 = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (row1 < 0 || row1 >= n || col1 < 0 || col1 >= jagged[row1].Length)
                {
                    continue;
                }

                if (command == "Add")
                {
                    jagged[row1][col1] += value;
                }
                else if (command == "Subtract")
                {
                    jagged[row1][col1] -= value;
                }
            }
        }

        private static void Initiallize(int n, int[][] jagged)
        {
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                jagged[row] = new int[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    jagged[row][col] = int.Parse(input[col]);
                }
            }
        }

        private static void AnalizeThis(int n, int[][] jagged)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
