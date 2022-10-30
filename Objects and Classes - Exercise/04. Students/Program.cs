using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that sorts some students by their grade in descending order. Each student should have:
            //•	First name(String)
            //•	Last name(String)
            //•	Grade(a floating - point number)
            //Input
            //•	On the first line, you will receive a number n - the count of all students.
            //•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".
            //Output
            //•	Print out the information about each student in the following format: "{first name} {second name}: {grade}".
            //Create a program that sorts some students by their grade in descending order. Each student should have:
            //•	First name(String)
            //•	Last name(String)
            //•	Grade(a floating - point number)
            //Input
            //•	On the first line, you will receive a number n - the count of all students.
            //•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".
            //Output
            //•	Print out the information about each student in the following format: "{first name} {second name}: {grade}".
            List<Student> students = new List<Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            List<Student> descending = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in descending)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade:f2}");
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
