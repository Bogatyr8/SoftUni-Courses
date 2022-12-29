using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class called Student, which will hold the following information about some students: 
            //•	first name
            //•	last name
            //•	age
            //•	home town
            //Input / Constraints
            //Read information about some students, until you receive the "end" command.After that, you will receive a city name.
            //Output
            //Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

            List<Student> students = new List<Student>();


            string inputString;
            while ((inputString = Console.ReadLine()) != "end")
            {
                string[] input = inputString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                students.Add(student);
            }

            string town = Console.ReadLine();

            List<Student> filteredStudents = students
                .Where(x => x.HomeTown == town)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }


    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
