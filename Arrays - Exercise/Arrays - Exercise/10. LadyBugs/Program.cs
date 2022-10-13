using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
//You are given a field size and the indexes where ladybugs can be found on the field.On every new line, until the "end" command is given,
//a ladybug changes its position either to its left or to its right by a given fly length. A movement description command looks like this:
//"0 right 1".This means that the little insect placed on index 0 should fly one index to its right.If the ladybug lands on another ladybug,
//it continues to fly in the same direction repeating the specified flight length. If the ladybug flies out of the field, it is gone.
//For example, you are given a field of size 3 there are ladybugs on indexes 0 and 1.If the ladybug on index 0 needs to fly to its right by
//the length of 1(0 right 1) it will attempt to land on index 1 but as there is another ladybug there, so it will continue further to the
//right passing 1 index in length, landing on index 2.After that, if the same ladybug needs to fly to its right passing 1 index(2 right 1),
//it will land somewhere outside of the field, so it flies away:

//If we receive an initial index that does not contain a ladybug nothing happens. If you are given a ladybug index that is outside the field, nothing happens. In the end, print all cells of the field separated by blank spaces. For each cell that has a ladybug in it print '1' and for each empty cell print '0'.The output of the example above should be '0 1 0'.
//Input
//•	On the first line, you will receive an integer - the size of the field
//•	On the second line, you will receive the initial indexes of all ladybugs separated by a blank space
//•	On the next lines, until you get the "end" command you will receive commands in the format: "{ladybug index} {direction} {fly length}"

//Output
//•	Print all field cells in format: "{cell} {cell} … {cell}"
//o   If a cell has a ladybug in it, print '1'
//o   If a cell is empty, print '0'
// Constrains
//•	The size of the field will be in the range[0 … 1000]
//•	The ladybug indexes will be in the range[-2, 147, 483, 647 … 2, 147, 483, 647]
//•	The number of commands will be in the range[0 … 100] 
//•	The fly length will be in the range[-2, 147, 483, 647 … 2, 147, 483, 647]
            int fieldSize = int.Parse(Console.ReadLine());
            string ladybirdsInput = " " + Console.ReadLine();

            int[] field = new int[fieldSize];
            if (ladybirdsInput != " ")
            {
                int[] ladybirds = ladybirdsInput
                        .Split(" ")
                        .Select(int.Parse)
                        .ToArray();
                for (int i = 0; i < ladybirds.Length; i++)
                {
                    int ladybirdIndex = 0;
                    if (ladybirds[i] < fieldSize)
                    {
                        ladybirdIndex = ladybirds[i];
                        field[ladybirdIndex] = 1;
                    }
                }
            }
            string commandInput = Console.ReadLine();
            while (commandInput != "end")
            {
                string[] command = commandInput.Split(" ");
                int ladybirdLocation = int.Parse(command[0]);
                int ladybirdSpeed = int.Parse(command[2]);
                string ladybirsDirection = command[1];
                int movement = 0;
                switch (ladybirsDirection)
                {
                    case "left": // Going left
                        movement = ladybirdLocation - ladybirdSpeed;
                        field[ladybirdLocation] = 0;
                        if (movement < 0) // If movement exceeds the boundaries of field
                        {
                            commandInput = Console.ReadLine();
                            continue;
                        }
                        else // If movement is within boundaries of field
                        {
                            while (!(field[movement] == 0 && movement >= 0)) // Keep moving until clear, then settle
                            {
                                if (field[movement] == 1)  // Is the place already occupied? Yes
                                {
                                    movement -= ladybirdSpeed;

                                    if (movement < 0)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    field[movement] = 1;
                                    continue;
                                }
                            }
                            if (movement >= 0)
                            {
                                field[movement] = 1;
                            }
                        }
                        break;
                    case "right":
                        movement = ladybirdLocation + ladybirdSpeed;
                        field[ladybirdLocation] = 0;
                        if (movement >= fieldSize) // If movement exceeds the boundaries of field
                        {
                            commandInput = Console.ReadLine();
                            continue;
                        }
                        else // If movement is within boundaries of field
                        {
                            while (!(field[movement] == 0 && movement < fieldSize)) // Keep moving until clear, then settle
                            {
                                if (field[movement] == 1)  // Is the place already occupied? Yes
                                {
                                    movement += ladybirdSpeed;
                                    if (movement == fieldSize)
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    field[movement] = 1;
                                    continue;
                                }
                            }
                            if (movement < fieldSize)
                            {
                                field[movement] = 1;
                            }
                        }
                        break;
                }
                commandInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
