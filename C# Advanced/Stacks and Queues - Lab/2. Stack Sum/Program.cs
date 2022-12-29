using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that:
            //•	Reads an input of integer numbers and adds them to a stack
            //•	Reads command until "end" is received
            //•	Prints the sum of the remaining elements of the stack
            //Input
            //•	On the first line, you will receive an array of integers
            //•	On the next lines, until the "end" command is given, you will receive commands – a single
            //command and one or two numbers after the command, depending on what command you are given
            //•	If the command is "add", you will always receive exactly two numbers after the command which
            //you need to add to the stack
            //•	If the command is "remove", you will always receive exactly one number after the command
            //which represents the count of the numbers you need to remove from the stack. If there are not
            //enough elements skip the command.
            //Output
            //•	When the command "end" is received, you need to print the sum of the remaining elements in
            //the stack
            int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string inputLine;
            while ((inputLine = Console.ReadLine().ToLower()) != "end")
            {
                string[] input = inputLine.Split();
                string command = input[0];
                if (command == "add")
                {
                    int first = int.Parse(input[1]);
                    int second = int.Parse(input[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else if (command == "remove")
                {
                    int values = int.Parse(input[1]);
                    if (values > stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < values; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            int total = 0;
            while (stack.Count > 0)
            {
                total += stack.Pop();
            }
            Console.WriteLine($"Sum: {total}");
        }
    }
}
