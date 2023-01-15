namespace _04._Even_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that prints a number from a collection, which appears an even number of times in
//it.On the first line, you will be given n – the count of integers you will receive.On the next
//n lines, you will be receiving the numbers. It is guaranteed that only one of them appears an
//even number of times. Your task is to find that number and print it in the end. 
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(value))
                {
                    numbers.Add(value, 0);
                }
                numbers[value]++;
            }

            numbers = numbers.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in numbers)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
