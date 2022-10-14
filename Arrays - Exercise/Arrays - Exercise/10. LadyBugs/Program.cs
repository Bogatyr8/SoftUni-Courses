using System;
using System.Linq;
using System.Numerics;

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

            // 1.0 Initiallize initial parameteres and fields
            long fieldSize = long.Parse(Console.ReadLine());

            long[] field = new long[fieldSize];

            string ladybirdsInput = Console.ReadLine();
            long[] ladybirds = ladybirdsInput
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
            foreach (int index in ladybirds)
            {
                field[index] = 1;
            }
            string commandInput = Console.ReadLine();
            while (commandInput != "end")
            { // 2.0 Initiallize comand instructions
                string[] command = commandInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                long ladybirdLocation = long.Parse(command[0]);
                long ladybirdSpeed = long.Parse(command[2]);
                string ladybirsDirection = command[1];
                // 3.0 Scanning for ladybird 
                if (ladybirdLocation < 0 || ladybirdLocation >= fieldSize)
                {
                    commandInput = Console.ReadLine();
                    continue;
                }
                if (field[ladybirdLocation] == 0)
                {
                    commandInput = Console.ReadLine();
                    continue;
                }
                // 4.0 Found a ladybird
                field[ladybirdLocation] = 0; // ladyird has left its initial place
                if (ladybirsDirection == "left")
                {
                    ladybirdSpeed *= -1;
                }
                long movement = ladybirdLocation + ladybirdSpeed;  // ladbird is moving.
                if (movement < 0 || movement >= fieldSize)
                {
                    commandInput = Console.ReadLine();
                    continue;
                }
                while (movement >= 0 && movement < fieldSize)
                {
                    if (field[movement] == 0) // free spot
                    {
                        field[movement] = 1; // land here
                    }
                    else
                    {
                        movement += ladybirdSpeed;// there is another ladybird on the new place. Proceed with the movement.
                    }
                }
                commandInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
