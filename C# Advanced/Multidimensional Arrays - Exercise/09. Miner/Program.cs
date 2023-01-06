namespace _09._Miner
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //We get as input the size of the field in which our miner moves. The field is always a square. After that,
            //we will receive the commands which represent the directions in which the miner should move. The miner
            //starts from position – 's'.The commands will be: left, right, up, and down. If the miner has reached a
            //side edge of the field and the next command indicates that he has to get out of the field, he must
            //remain in his current position and ignore the current command. The possible characters that may appear
            //on the screen are:
            //•	* – a regular position on the field
            //•	e – the end of the route.
            //•	c - coal
            //•	s - the place where the miner starts
            //Each time when the miner finds coal, he collects it and replaces it with '*'.Keep track of the count of
            //the collected coals. If the miner collects all of the coals in the field, the program stops and you have
            //to print the following message: "You collected all coals! ({rowIndex}, {colIndex})".
            //If the miner steps at 'e' the game is over(the program stops) and you have to print the following
            //message: "Game over! ({rowIndex}, {colIndex})".
            //If there are no more commands and none of the above cases had happened, you have to print the following
            //message: "{remainingCoals} coals left. ({rowIndex}, {colIndex})".
            //Input
            //•	Field size – an integer number.
            //•	Commands to move the miner – an array of strings separated by  ' '.
            //•	The field: some of the following characters(*, e, c, s), separated by whitespace(' ').
            //Output
            //•	There are three types of output:
            //o If all the coals have been collected, print the following output:
            //"You collected all coals! ({rowIndex}, {colIndex})".
            //o If you have reached the end, you have to stop moving and print the following line:
            //"Game over! ({rowIndex}, {colIndex})".
            //o If there are no more commands and none of the above cases had happened, you have to print the
            //following message: "{totalCoals} coals left. ({rowIndex}, {colIndex})".
            //Constraints
            //•	The field size will be a 32 - bit integer in the range[0…2147483647].
            //•	The field will always have only one's.
            //•	Allowed working time for your program: 0.1 seconds.
            //• llowed memory: 16 MB.
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            string[] commands = Console.ReadLine().Split();
            Initiallize(n, matrix);

            int startRow = 0, startCol = 0;
            LocateTheStartingPoint(n, matrix, ref startRow, ref startCol);

            int coalsDeposits = 0;
            coalsDeposits = CoalDeposits(matrix, coalsDeposits);

            int currRow = startRow, currCol = startCol;
            int coalsCollected = 0;
            Action(matrix, commands, ref currRow, ref currCol, ref coalsCollected, coalsDeposits);

        }
        private static void Action(string[,] matrix, string[] commands, ref int currRow, ref int currCol, ref int coalsCollected, int coalsDeposits)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    currRow--;
                    if (currRow < 0)
                    {
                        currRow++;
                    }
                }
                else if (commands[i] == "down")
                {
                    currRow++;
                    if (currRow >= matrix.GetLength(0))
                    {
                        currRow--;
                    }
                }
                else if (commands[i] == "left")
                {
                    currCol--;
                    if (currCol < 0)
                    {
                        currCol++;
                    }
                }
                else if (commands[i] == "right")
                {
                    currCol++;
                    if (currCol >= matrix.GetLength(1))
                    {
                        currCol--;
                    }
                }
                if (matrix[currRow, currCol] == "c")
                {
                    coalsCollected++;
                    matrix[currRow, currCol] = "*";
                }
                
                if (matrix[currRow, currCol] == "e")
                {
                    Console.WriteLine($"Game over! ({currRow}, {currCol})");
                    return;
                }
                else if (coalsCollected == coalsDeposits)
                {
                    Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
                    return;
                }
                else if (i == commands.Length - 1)
                {
                    Console.WriteLine($"{coalsDeposits - coalsCollected} coals left. ({currRow}, {currCol})");
                    break;
                }
            }
        }

        private static int CoalDeposits(string[,] matrix, int coalsDeposits)
        {
            foreach (var item in matrix)
            {
                if (item == "c")
                {
                    coalsDeposits++;
                }
            }

            return coalsDeposits;
        }

        private static void LocateTheStartingPoint(int n, string[,] matrix, ref int startRow, ref int startCol)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == "s")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }

        private static void Initiallize(int n, string[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
