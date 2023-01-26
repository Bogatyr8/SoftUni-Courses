namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a line of integers separated by ", ". Print on two lines the count of numbers and their sum.
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int sum = numbers.Sum();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(sum);
        }
    }
}
