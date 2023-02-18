
using System.Text;

public class StartUp
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        TheMatrix room = new(dimensions[0], dimensions[1]);

        char[,] theRoom = room.ReadMatrix();
        BlindfoldedMan blindfoldedMan = new(theRoom);
        blindfoldedMan.LocateBlindfolded();
        string command;
        
        while ((command = Console.ReadLine()) != "Finish" && blindfoldedMan.Score != 3)
        {
            blindfoldedMan.Move(command);

            //Console.WriteLine();
            //room.RefreshMatrix(theRoom);
            //Console.WriteLine(room.PrintMatrix());
            if (blindfoldedMan.Score == 3)
            {
                break;
            }
        }

        Console.WriteLine("Game over!");
        Console.WriteLine($"Touched opponents: {blindfoldedMan.Score} Moves made: {blindfoldedMan.MovesCounter}");

    }
}
public class BlindfoldedMan
{
    public BlindfoldedMan(char[,] room)
    {
        this.TheRoom = room;
        this.Score = 0;
        this.MovesCounter = 0;
    }
    public char[,] TheRoom { get; set; }
    public int BlindfoldedRow { get; set; }
    public int BlindfoldedCol { get; set; }
    public int Score { get; set; }
    public int MovesCounter { get; set; }
    public void LocateBlindfolded()
    {
        for (int row = 0; row < TheRoom.GetLength(0); row++)
        {
            for (int col = 0; col < TheRoom.GetLength(1); col++)
            {
                if (TheRoom[row, col] == 'B')
                {
                    BlindfoldedRow = row;
                    BlindfoldedCol = col;
                }
            }
        }
    }
    public void Move(string direction)
    {
        SetToDash(BlindfoldedRow, BlindfoldedCol);

        if (direction == "up")
        {
            if (CheckForObstaclesAndBoundaries(direction))
            {
                SetToBlindfolded(BlindfoldedRow, BlindfoldedCol);
                return;
            }
            BlindfoldedRow--;
        }
        else if (direction == "down")
        {
            if (CheckForObstaclesAndBoundaries(direction))
            {
                SetToBlindfolded(BlindfoldedRow, BlindfoldedCol);
                return;
            }
            BlindfoldedRow++;
        }
        else if (direction == "left")
        {
            if (CheckForObstaclesAndBoundaries(direction))
            {
                SetToBlindfolded(BlindfoldedRow, BlindfoldedCol);
                return;
            }
            BlindfoldedCol--;
        }
        else if (direction == "right")
        {
            if (CheckForObstaclesAndBoundaries(direction))
            {
                SetToBlindfolded(BlindfoldedRow, BlindfoldedCol);
                return;
            }
            BlindfoldedCol++;
        }
        MovesCounter++;
        ScorePoints();
        SetToBlindfolded(BlindfoldedRow, BlindfoldedCol);
    }
    public void SetToDash(int row, int col)
    {
        this.TheRoom[row, col] = '-';
    }
    public void SetToBlindfolded(int row, int col)
    {
        this.TheRoom[row, col] = 'B';
    }
    private void ScorePoints() //fix
    {
        var a = TheRoom[BlindfoldedRow, BlindfoldedCol];
        if (a == 'P')
        {
            Score++;
        }
    }
    private bool CheckForObstaclesAndBoundaries(string direction) //fix
    {
        var a = TheRoom[BlindfoldedRow, BlindfoldedCol];
        int temp;
        if (direction == "up")
        {
            if (BlindfoldedRow == 0)
            {
                return true;
            }
            temp = BlindfoldedRow - 1;
            var b = TheRoom[temp, BlindfoldedCol];
            if (b == 'O')
            {
                return true;
            }
        }
        else if (direction == "down")
        {
            if (BlindfoldedRow == TheRoom.GetLength(0) - 1)
            {
                return true;
            }
            temp = BlindfoldedRow + 1;
            var b = TheRoom[temp, BlindfoldedCol];
            if (b == 'O')
            {
                return true;
            }
        }
        else if (direction == "left")
        {
            if (BlindfoldedCol == 0)
            {
                return true;
            }
            temp = BlindfoldedCol - 1;
            var b = TheRoom[BlindfoldedRow, temp];
            if (b == 'O')
            {
                return true;
            }
        }
        else if (direction == "right")
        {
            if (BlindfoldedCol == TheRoom.GetLength(1) - 1)
            {
                return true;
            }
            temp = BlindfoldedCol + 1;
            var b = TheRoom[BlindfoldedRow, temp];
            if (b == 'O')
            {
                return true;
            }
        }
        return false;
    }
}
public class TheMatrix
{
    public TheMatrix(int n, int m)
    {
        this.N = n;
        this.M = m;
        this.Matrix = new char[N, M];
    }
    public int N { get; set; }
    public int M { get; set; }
    public char[,] Matrix { get; set; }
    public char[,] ReadMatrix()
    {
        for (int row = 0; row < N; row++)
        {
            char[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            for (int col = 0; col < M; col++)
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