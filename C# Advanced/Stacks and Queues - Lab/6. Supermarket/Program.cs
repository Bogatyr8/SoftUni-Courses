using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
//Reads an input consisting of a name and adds it to a queue until "End" is received.If you receive
//"Paid", print every customer name and empty the queue, otherwise, we receive a client and we have to
//add him to the queue. When we receive "End" we have to print the count of the remaining people in the
//queue in the format: "{count} people remaining.".
            Queue<string> queue = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join("\n", queue));
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
