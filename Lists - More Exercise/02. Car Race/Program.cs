using System;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the winner of a car race.You will receive an array of numbers.Each element of the array represents the time needed to pass through
            //that step(the index). There are going to be two cars.One of them starts from the left side and the other one starts from the right side.The middle index of the
            //array is the finish line.The number of elements in the array will always be odd.Calculate the total time for each racer to reach the finish, which is the
            //middle of the array, and print the winner with his total time (the racer with less time). If you have a zero in the array, you have to reduce the time of the
            //racer that reached it by 20% (from his current time).
            //Print the result in the following format "The winner is {left/right} with total time: {total time}".

            int[] raceTimes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            double left = 0;
            double right = 0;
            for (int i = 0; i < raceTimes.Length / 2; i++)
            {

                left += raceTimes[i];
                right += raceTimes[raceTimes.Length - i - 1];
                if (raceTimes[i] == 0)
                {
                    left *= 0.8;
                }

                if (raceTimes[raceTimes.Length - i - 1] == 0)
                {
                    right *= 0.8;
                }
            }
            int leftD = (int)(left * 10) % 10;
            int rightD = (int)(right * 10) % 10;

            if (left < right)
            {
                if (leftD == 0)
                {
                    Console.WriteLine($"The winner is left with total time: {left:f0}");
                }
                else
                {
                    Console.WriteLine($"The winner is left with total time: {left:f1}");
                }
            }
            else if (left > right)
            {
                if (rightD == 0)
                {
                    Console.WriteLine($"The winner is right with total time: {right:f0}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {right:f1}");
                }
            }
        }
    }
}
