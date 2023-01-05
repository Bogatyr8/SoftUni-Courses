namespace _07._Knight_Game
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //Chess is the oldest game, but it is still popular these days. For this task we will use only one chess
            //piece – the Knight. 
            //The knight moves to the nearest square, but not on the same row, column or diagonal. (This can be thought
            //of as moving two squares horizontally, then one square vertically, or moving one square horizontally,
            //then two squares vertically— i.e. in an "L" pattern.) 
            //The knight game is played on a board with dimensions N x N and a lot of chess knights 0 <= K <= N2.
            //You will receive a board with K for knights and '0' for empty cells. Your task is to remove a minimum
            //of the knights, so there will be no knights left that can attack another knight.
            //Input
            //•	On the first line, you will receive the N side of the board.
            //•	On the next N lines, you will receive strings with Ks and 0s.
            //Output
            //•	Print a single integer with the minimum number of knights that needs to be removed.
            //Constraints
            //•	Size of the board will be 0 < N < 30
            //•	Time limit: 0.3 sec.Memory limit: 16 MB.
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int[,] strikesMap = new int[n, n];
            Initiallize(n, matrix, strikesMap);
            int rowMax = 0;
            int colMax = 0;
            int removedKnights = 0;
            bool anyChanges = true;
            while (anyChanges)
            {
                EvaluaringTheField(n, matrix, strikesMap);
                FindAndRemoveTheBiggestAttacker(n, matrix, strikesMap, ref rowMax, ref colMax, ref removedKnights, ref anyChanges);
                RestoreToMinusOne(n, strikesMap);
            }
            Console.WriteLine(removedKnights);
        }

        private static void RestoreToMinusOne(int n, int[,] strikesMap)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (strikesMap[row, col] != 0)
                    {
                        strikesMap[row, col] = -1;
                    }
                }
            }
        }

        private static void FindAndRemoveTheBiggestAttacker(int n, char[,] matrix, int[,] strikesMap, ref int rowMax, ref int colMax, ref int removedKnights, ref bool anyChanges)
        {
            bool removeFlag = false;
            int maxValue = -1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (strikesMap[row, col] > maxValue && strikesMap[row, col] != 0)
                    {
                        rowMax = row;
                        colMax = col;
                        maxValue = strikesMap[row, col];
                        removeFlag = true;
                    }
                }
            }
            if (removeFlag)
            {
                strikesMap[rowMax, colMax] = 0;
                matrix[rowMax, colMax] = '0';
                removedKnights++;
                anyChanges = true;
            }
            else
            {
                anyChanges = false;
            }
        }

        private static void EvaluaringTheField(int n, char[,] matrix, int[,] strikesMap)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'K')
                    {
                        BattleScan(row, col, matrix, strikesMap);
                    }
                }
            }
        }

        private static void BattleScan(int row, int col, char[,] matrix, int[,] strikesMap)
        {
            for (int r = -2; r <= 2; r++)
            {
                for (int c = -2; c <= 2; c++)
                {
                    int rowCheck = row + r;
                    int colCheck = col + c;
                    if (rowCheck == row || colCheck == col ||
                        ((Math.Abs(r) - Math.Abs(c)) == 0) ||
                        rowCheck < 0 || colCheck < 0 || 
                        rowCheck >= strikesMap.GetLength(1) || colCheck >= strikesMap.GetLength(1))
                    {
                        continue;
                    }
                    else if (matrix[rowCheck, colCheck] == 'K')
                    {
                        if (strikesMap[rowCheck, colCheck] == -1)
                        {
                            strikesMap[rowCheck, colCheck] = 0;
                        }
                        strikesMap[rowCheck, colCheck]++;
                    }
                }
            }
        }

        private static void Initiallize(int n, char[,] matrix, int[,] strikesMap)
        {
            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 'K')
                    {
                        strikesMap[row, col] = -1;
                    }
                }
            }
        }
    }
}
