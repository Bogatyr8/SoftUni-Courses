﻿using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that simulates the queue that forms during a traffic jam.During a traffic jam, only N
//cars can pass the crossroads when the light goes green.Then the program reads the vehicles that arrive
//one by one and adds them to the queue.When the light goes green N number of cars pass the crossroads
//and for each, a message "{car} passed!" is displayed.When the "end" command is given, terminate the
//program and display a message with the total number of cars that passed the crossroads.
//Input
//•	On the first line, you will receive N – the number of cars that can pass during a green light
//•	On the next lines, until the "end" command is given, you will receive commands – a single string,
//either a car or "green"
//Output
//•	Every time the "green" command is given, print out a message for every car that passes the
//crossroads in the format "{car} passed!"
//•	When the "end" command is given, print out a message in the format "{number of cars} cars passed
//the crossroads."
            Queue<string> carQueue = new Queue<string>();
            int passRate = int.Parse(Console.ReadLine());
            int carsPassed = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < passRate; i++)
                    {
                        if (carQueue.Count != 0)
                        {
                            carsPassed++;
                            Console.WriteLine($"{carQueue.Dequeue()} passed!");
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}