using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that:
//•	Reads an array of integers and adds them to a queue
//•	Prints the even numbers separated by ", "
//Hints
//•	Use a Queue<int>
//•	Use the methods Enqueue(), Dequeue(), Peek()

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbers = new Queue<int>(input);
            int turns = numbers.Count();
            for (int i = 0; i < turns; i++)
            {
                int value = numbers.Dequeue();
                if (value % 2 == 0)
                {
                    numbers.Enqueue(value);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
