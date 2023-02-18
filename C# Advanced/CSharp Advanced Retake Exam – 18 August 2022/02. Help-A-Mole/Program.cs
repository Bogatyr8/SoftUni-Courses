using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheMatrix field= new TheMatrix(int.Parse(Console.ReadLine()));

            char[,] theField = field.ReadMatrix();
            Mole mole = new Mole(theField);
            mole.LocateSpecialObjects();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                mole.Move(command);

                //Console.WriteLine();
                //field.RefreshMatrix(theField);
                //Console.WriteLine(field.PrintMatrix());
                if (mole.Score >= 25)
                {
                    break;
                }
            }

            if (mole.Score >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {mole.Score} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {mole.Score} points.");
            }
            field.RefreshMatrix(theField);
            Console.WriteLine(field.PrintMatrix());

        }
    }
    public class Mole
    {
        public Mole(char[,] field)
        {
            this.MoleField = field;
            this.Score = 0;
        }
        public char[,] MoleField { get; set; }
        public int MoleRow { get; set; }
        public int MoleCol { get; set; }
        public int S1Row { get; set; }
        public int S1Col { get; set; }
        public int S2Row { get; set; }
        public int S2Col { get; set; }
        public int Score { get; set; }
        public void LocateSpecialObjects()
        {
            bool isFirstFound = false;
            for (int row = 0; row < MoleField.GetLength(0); row++)
            {
                for (int col = 0; col < MoleField.GetLength(1); col++)
                {
                    if (MoleField[row, col] == 'M')
                    {
                        MoleRow = row;
                        MoleCol = col;
                    }
                    if (MoleField[row, col] == 'S')
                    {
                        if (!isFirstFound)
                        {
                            isFirstFound = true;
                            S1Row = row;
                            S1Col = col;
                        }
                        else
                        {
                            S2Row = row;
                            S2Col = col;
                        }
                    }
                }
            }
        }
        public void Move(string direction)
        {
            SetToDash(MoleRow, MoleCol);

            if (direction == "up")
            {
                if (MoleRow == 0)
                {
                    SetToMole(MoleRow, MoleCol);
                    Console.WriteLine("Don't try to escape the playing field!");
                    return;
                }
                MoleRow--;
            }
            else if (direction == "down")
            {
                if (MoleRow == MoleField.GetLength(0) - 1)
                {
                    SetToMole(MoleRow, MoleCol);
                    Console.WriteLine("Don't try to escape the playing field!");
                    return;
                }
                MoleRow++;
            }
            else if (direction == "left")
            {
                if (MoleCol == 0)
                {
                    SetToMole(MoleRow, MoleCol);
                    Console.WriteLine("Don't try to escape the playing field!");
                    return;
                }
                MoleCol--;
            }
            else if (direction == "right")
            {
                if (MoleCol == MoleField.GetLength(1) - 1)
                {
                    SetToMole(MoleRow, MoleCol);
                    Console.WriteLine("Don't try to escape the playing field!");
                    return;
                }
                MoleCol++;
            }
            ScorePoints();
            Teleport();
            SetToMole(MoleRow, MoleCol);
        }
        public void SetToDash(int row, int col)
        {
            this.MoleField[row, col] = '-';
        }
        public void SetToMole(int row, int col)
        {
            this.MoleField[row, col] = 'M';
        }
        private void ScorePoints()
        {
            var a = MoleField[MoleRow, MoleCol];
            if (a != 'S' && a != 'M' && a != '-')
            {
                int point = int.Parse(a.ToString());
                this.Score += point;
            }
        }
        private void Teleport()
        {
            if (MoleRow == S1Row && 
                MoleCol == S1Col && 
                MoleField[MoleRow, MoleCol] == 'S')
            {
                SetToDash(S1Row, S1Col);
                MoleRow = S2Row;
                MoleCol = S2Col;
                Score -= 3;
            }
            else if (MoleRow == S2Row && 
                MoleCol == S2Col && 
                MoleField[MoleRow, MoleCol] == 'S')
            {
                SetToDash(S2Row, S2Col);
                MoleRow = S1Row;
                MoleCol = S1Col;
                Score -= 3;
            }
        }
    }
    public class TheMatrix
    {
        public TheMatrix(int n)
        {
            this.N = n;
            this.Matrix = new char[N, N];
        }
        public int N { get; set; }
        public char[,] Matrix { get; set; }
        public char[,] ReadMatrix()
        {
            for (int row = 0; row < N; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < N; col++)
                {
                    Matrix[row, col] = input[col];
                }
            }
            return Matrix;

        }
        public string PrintMatrix()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    sb.Append($"{Matrix[row, col]}");
                }
                sb.AppendLine();
            }
            return sb.ToString().Trim();
        }
        public void RefreshMatrix(char[,] matrix)
        {
            this.Matrix = matrix;
        }
    }
}
