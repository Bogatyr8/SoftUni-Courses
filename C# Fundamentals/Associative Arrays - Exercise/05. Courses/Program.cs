using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that keeps the information about courses.Each course has a name and registered students.
//You will be receiving a course name and a student name, until you receive the command "end".Check if such a course already
//exists, and if not, add the course.Register the user into the course. When you receive the command "end", print the courses
//with their names and total registered users. For each contest print the registered users.
//Input
//•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
//•	The product data is always delimited by " : ".
//Output
//•	Print the information about each course in the following the format: 
//"{courseName}: {registeredStudents}"
//•	Print the information about each student in the following the format:
//"-- {studentName}"
            Dictionary<string, List<string>> cources = new Dictionary<string, List<string>>();
            string inputString;

            while ((inputString = Console.ReadLine()) != "end")
            {
                string[] input = inputString
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = input[0];
                string student = input[1];

                if (!cources.ContainsKey(course))
                {
                    cources.Add(course, new List<string>());
                }
                cources[course].Add(student);
            }

            foreach (var courseName in cources)
            {
                Console.WriteLine($"{courseName.Key}: {courseName.Value.Count}");

                foreach (var student in courseName.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
