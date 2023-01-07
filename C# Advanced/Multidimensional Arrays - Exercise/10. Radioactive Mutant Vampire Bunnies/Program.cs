namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
//Browsing through GitHub, you come across an old JS Basics teamwork game.It is about very nasty bunnies
//that multiply extremely fast. There's also a player that has to escape from their lair. You like the
//game, so you decide to port it to C# because that's your language of choice.The last thing that is left
//is the algorithm that decides if the player will escape the lair or not.
//First, you will receive a line holding integers N and M, which represent the rows and columns in the
//lair. Then you receive N strings that can only consist of '.', 'B', 'P'.The bunnies are marked with 'B',
//the player is marked with 'P', and everything else is free space, marked with a dot '.'.They represent
//the initial state of the lair.There will be only one player. Then you will receive a string with
//commands such as LLRRUUDD – where each letter represents the next move of the player
//(Left, Right, Up, Down).
//After each step of the player, each of the bunnies spread to the up, down, left and right(neighboring
//cells marked as '.' changes their value to 'B').If the player moves to a bunny cell or a bunny reaches
//the player, the player has died. If the player goes out of the lair without encountering a bunny, the
//player has won.
//When the player dies or wins, the game ends. All the activities for this turn continue (e.g.all the
//bunnies spread normally), but there are no more turns. There will be no stalemates where the moves of
//the player end before he dies or escapes.
//Finally, print the final state of the lair with every row on a separate line. On the last line, print
//either "dead: {row} {col}" or "won: {row} {col}".Row and col are the coordinates of the cell where the
//player has died or the last cell he has been in before escaping the lair.
//Input
//•	On the first line of input, the numbers N and M are received – the number of rows and columns in
//the lair.
//•	On the next N lines, each row is received in the form of a string.The string will contain only '.',
//'B', 'P'.All strings will be the same length. There will be only one 'P' for all the input.
//•	On the last line, the directions are received in the form of a string, containing 'R', 'L', 'U', 'D'.
//Output
//•	On the first N lines, print the final state of the bunny lair.
//•	On the last line, print the outcome – "won:" or "dead:" + { row}
//            { col}.
//Constraints
//•	The dimensions of the lair are in the range[3…20].
//•	The directions string length is in the range[1…20].
            string[] sizes = Console.ReadLine().Split();
            int n = int.Parse(sizes[0]);
            int m = int.Parse(sizes[1]);
            char[,] matrix = new char[n, m];
            Initiallize(matrix);
            char[] commands = Console.ReadLine().ToCharArray();

            int startRow = 0, startCol = 0;
            LocateTheStartingPoint(matrix, ref startRow, ref startCol);

            int currRow = startRow, currCol = startCol;
            bool escapeGame = false;
            bool deadInGame = false;
            for (int i = 0; i < commands.Length; i++)
            {
                PlayerAction(matrix, commands, ref currRow, ref currCol, ref escapeGame, ref deadInGame, i);

                BunnySpreading(matrix, ref deadInGame, i);
                if (escapeGame || deadInGame)
                {
                    break;
                }
            }

            PrintMatrix(matrix);
            if (escapeGame)
            {
                Console.WriteLine($"won: {currRow} {currCol}");
            }
            else if (deadInGame)
            {
                Console.WriteLine($"dead: {currRow} {currCol}");
            }
        }

        private static void BunnySpreading(char[,] matrix, ref bool deadInGame, int i)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 'B')
                    {
                        if ((r - 1) >= 0)
                        {
                            if (matrix[r - 1, c] == 'P')
                            {
                                deadInGame = true;
                                matrix[r - 1, c] = 'T';
                                return;
                            }
                            matrix[r - 1, c] = 'T';
                        }
                        if ((c + 1) < matrix.GetLength(1))
                        {
                            if (matrix[r, c + 1] == 'P')
                            {
                                deadInGame = true;
                                matrix[r, c + 1] = 'T';
                                return;
                            }
                            matrix[r, c + 1] = 'T';
                        }
                        if ((r + 1) < matrix.GetLength(0))
                        {
                            if (matrix[r + 1, c] == 'P')
                            {
                                deadInGame = true;
                                matrix[r + 1, c] = 'T';
                                return;
                            }
                            matrix[r + 1, c] = 'T';
                        }
                        if ((c - 1) >= 0)
                        {
                            if (matrix[r, c - 1] == 'P')
                            {
                                deadInGame = true;
                                matrix[r, c - 1] = 'T';
                                return;
                            }
                            matrix[r, c - 1] = 'T';
                        }
                    }
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 'T')
                    {
                        matrix[r, c] = 'B';
                    }
                }
            }
        }

        private static void PlayerAction(char[,] matrix, char[] commands, ref int currRow, ref int currCol, ref bool escapeGame, ref bool deadInGame, int i)
        {
            matrix[currRow, currCol] = '.';

            if (commands[i] == 'U')
            {
                currRow--;
                if (currRow < 0)
                {
                    escapeGame = true;
                    currRow++;
                    matrix[currRow, currCol] = '.';
                    return;
                }
            }
            else if (commands[i] == 'D')
            {
                currRow++;
                if (currRow >= matrix.GetLength(0))
                {
                    escapeGame = true;
                    currRow--;
                    matrix[currRow, currCol] = '.';
                    return;
                }
            }
            else if (commands[i] == 'L')
            {
                currCol--;
                if (currCol < 0)
                {
                    escapeGame = true;
                    currCol++;
                    matrix[currRow, currCol] = '.';
                    return;
                }
            }
            else if (commands[i] == 'R')
            {
                currCol++;
                if (currCol >= matrix.GetLength(1))
                {
                    escapeGame = true;
                    currCol--;
                    matrix[currRow, currCol] = '.';
                    return;
                }
            }

            if (matrix[currRow, currCol] == 'B')
            {
                deadInGame = true;
                return;
            }

            matrix[currRow, currCol] = 'P';
        }

        private static void LocateTheStartingPoint(char[,] matrix, ref int startRow, ref int startCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
        }

        private static void Initiallize(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
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
