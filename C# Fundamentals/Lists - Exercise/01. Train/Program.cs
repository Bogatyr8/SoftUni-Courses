using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
//On the first line, we will receive a list of wagons(integers). Each integer represents the number of passengers that are currently in each wagon of a passenger train. On the next line, you will receive the max capacity of a wagon represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:
//•	Add { passengers} – add a wagon to the end of the train with the given number of passengers.
//•	{ passengers} -find a single wagon to fit all the incoming passengers(starting from the first wagon).
//In the end, print the final state of the train(all the wagons separated by a space).
            string inputOfWagons = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());

            List<int> train = inputOfWagons
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input
                .Split(' ')
                .ToList();

                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    int newPassengers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if ((train[i] + newPassengers) <= capacity)
                        {
                            train[i] += newPassengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', train));
        }
    }
}
