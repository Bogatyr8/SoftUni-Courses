using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Play around with a queue.You will be given an integer N representing the number of elements to
            //enqueue(add), an integer S, representing the number of elements to dequeue(remove) from the queue,
            //and finally an integer X, an element that you should look for in the queue.If it is, print true on
            //the console.If it's not printed the smallest element is currently present in the queue. If there are
            //no elements in the sequence, print 0 on the console.
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
            Queue<int> stack = new Queue<int>(data);
            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }

            bool zeroFlag = stack.Count == 0;
            bool searchFlag = true;
            int minValue = int.MaxValue;
            while (stack.Count > 0)
            {
                int check = stack.Dequeue();
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