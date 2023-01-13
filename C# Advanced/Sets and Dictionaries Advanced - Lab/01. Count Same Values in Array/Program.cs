namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that counts in a given array of double values the number of occurrences of each
//value. 
            Dictionary<double, int> values = new Dictionary<double, int>();
            double[] inputValues = Console.ReadLine()
                .Split()
                .Select(x => double.Parse(x))
                .ToArray();
            foreach (var item in inputValues)
            {
                if (!values.ContainsKey(item))
                {
                    values.Add(item, 0);
                }
                values[item]++;
            }

            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
