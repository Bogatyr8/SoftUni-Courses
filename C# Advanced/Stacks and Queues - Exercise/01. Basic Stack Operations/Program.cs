using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
//Play around with a stack.You will be given an integer N representing the number of elements to push into
//the stack, an integer S representing the number of elements to pop from the stack, and finally an
//integer X, an element that you should look for in the stack.If it's found, print "true" on the console.
//If it isn't, print the smallest element currently present in the stack.If there are no elements in the
//sequence, print 0 on the console.
//Input
//•	On the first line, you will be given N, S and X, separated by a single space.
//•	On the next line, you will be given N number of integers.
//Output
//•	On a single line, print either true if X is present in the stack, otherwise print the smallest element
//in the stack. If the stack is empty, print 0.
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = parameters[0];
            int s = parameters[1];
            int x = parameters[2];
            int[] data = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>(data);
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            bool zeroFlag = stack.Count == 0;
            bool searchFlag = true;
            int minValue = int.MaxValue;
            while (stack.Count > 0)
            {
                int check = stack.Pop();
                if (check == x)
                {
                    searchFlag = false;
                    Console.WriteLine("true");
                    return;
                }
                if (check <= minValue)
                {
                    minValue = check;
                }
            }
            if (zeroFlag)
            {
                Console.WriteLine(0);
            }
            else if (searchFlag)
            {
                Console.WriteLine(minValue);
            }

        }
    }
}
