using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
//Your program may receive the following commands:
//•	Delete { element} – delete all elements in the array, which are equal to the given element.
//•	Insert { element}
//{ position} – insert the element at the given position.
//You should exit the program when you receive the "end" command.Print all numbers in the array separated by a single whitespace.

            string inputOfList = Console.ReadLine();

            List<int> numbers = inputOfList
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input
                .Split(' ')
                .ToList();
                int value = int.Parse(command[1]);

                if (command[0] == "Delete")
                {
                    numbers.RemoveAll(x => x  == value);
                }
                else if(command[0] == "Insert")
                {
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, value);
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}