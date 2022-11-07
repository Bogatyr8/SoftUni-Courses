using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about students and their grades. 
            //You will receive n pair of rows.First, you will receive the student's name, after that, you will receive their grade. Check if
            //the student already exists and if not, add him. Keep track of all grades for each student.
            //When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
            //Print the students and their average grade in the following format:
            //"{name} –> {averageGrade}"
            //Format the average grade to the 2nd decimal place.
            Dictionary<string, List<double>> academy = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(studentName))
                {
                    academy.Add(studentName, new List<double>());
                }

                academy[studentName].Add(grade);
            }

            Dictionary<string, List<double>> sorted = new Dictionary<string, List<double>>();

            foreach (var item in academy)
            {
                if (item.Value.Average(x => x) >= 4.5)
                {
                    sorted.Add(item.Key, item.Value);
                }
            }

            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} –> {item.Value.Average():f2}");
            }
        }
    }
}
