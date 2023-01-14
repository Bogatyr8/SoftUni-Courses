namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
//Create a program, which reads a name of a student and his / her grades and adds them to the
//student record, then prints the students' names with their grades and their average grade.
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal value = decimal.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students.Add(input[0], new List<decimal>());
                }
                students[name].Add(value);
            }

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Key} -> {String.Join(" ", item.Value):f2} (avg: {item.Value.Average():f2})");
            //}

            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");

                foreach (decimal grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
