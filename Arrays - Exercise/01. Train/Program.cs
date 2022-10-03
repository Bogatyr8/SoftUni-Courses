using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //A train has an **n * *number of wagons(integer, received as input). On the next n lines, you will receive
            //the number of people that are going to get on each wagon.Print out the number of passengers in each wagon
            //followed by the total number of passengers on the train.
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sum);
        }
    }
}
