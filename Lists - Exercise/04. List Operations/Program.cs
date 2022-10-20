using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
//The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
//The possible commands are:
//•	Add { number} – add the given number to the end of the list
//•	Insert { number} { index} – insert the number at the given index
//•	Remove { index} – remove the number at the given index
//•	Shift left { count} – first number becomes last. This has to be repeated the specified number of times
//•	Shift right { count} – last number becomes first. To be repeated the specified number of times
//Note: the index given may be outside of the bounds of the array. In that case print: "Invalid index".
            List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();
            string order;
            while ((order = Console.ReadLine()) != "End")
            {
                string[] command = order
                    .Split();
                string operation = command[0];
                int value = 0;
                int index = 0;
                string direction = string.Empty;
                if (operation == "Add")
                {
                    value = int.Parse(command[1]);
                    numbers.Add(value);
                }
                else if (operation == "Insert")
                {
                    value = int.Parse(command[1]);
                    index = int.Parse(command[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, value);
                }
                else if (operation == "Remove")
                {
                    index = int.Parse(command[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);

                }
                else if (operation == "Shift")
                {
                    direction = command[1];
                    value = int.Parse(command[2]);
                    numbers = RotateList(numbers, direction, value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> RotateList(List<int> example, string direction, int count)
        {
            List<int> rotatedList = new List<int>();
            for (int i = 0; i < example.Count; i++)
            {
                rotatedList.Add(0);
            }
            int sign = 1;
            int offset = 0;

            for (int i = 0; i < example.Count; i++)
            {

                if (direction == "left")
                {
                    offset = (example.Count + i + (count % example.Count)) % example.Count;
                    rotatedList[i] = example[offset];
                }
                else
                {

                    offset = (example.Count + i - (count % example.Count)) % example.Count;
                    rotatedList[i] = example[offset];
                }
            }
            return rotatedList;
        }
    }
}
