using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Help planning the next Programming Fundamentals course by keeping track of the lessons, that are going to be included in the course, as well as all the exercises for the lessons. On the first input line, you will receive the initial schedule of lessons and exercises that are going to be part of the next course, separated by a comma and a space ", ".Before the course starts, there are some changes to be made.Until you receive the "course start" command, you will be given some commands to modify the course schedule.
            //The possible commands are:
            //•	Add:{ lessonTitle} – add the lesson to the end of the schedule, if it does not exist
            //•	Insert: { lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist
            //•	Remove: { lessonTitle} – remove the lesson, if it exists.
            //•	Swap: { lessonTitle}:{ lessonTitle} – swap the position of the two lessons, if they exist
            //Exercise:{ lessonTitle} – add Exercise in the schedule right after the lesson index, if the lesson exists and there is no exercise already, in the following format "{lessonTitle}-Exercise".If the lesson doesn`t exist, add the lesson at the end of the course schedule, followed by the Exercise.
            //Note: Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any following the lessons.
            //Input / Constraints
            //•	First - line – the initial schedule lessons – strings, separated by comma and space ", "
            //•	Until "course start" you will receive commands in the format described above
            //Output
            //•	Print the whole course schedule, each lesson on a new line with its number(index) in the schedule: 
            //"{lesson index}.{lessonTitle}"
            //•	Allowed working time / memory: 100ms / 16MB.
            List<string> program = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string commandInput;
            while ((commandInput = Console.ReadLine()) != "course start")
            {
                string[] command = commandInput
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string order = command[0];
                string lessonTitle = command[1];
                int index = 0;
                if (order == "Add")
                {
                    if (LessonCheck(program, lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        program.Add(lessonTitle);
                    }
                }
                else if (order == "Insert")
                {
                    if (LessonCheck(program, lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                    index = int.Parse(command[2]);
                    program.Insert(index, lessonTitle);
                    }
                }
                else if (order == "Remove")
                {
                    string exercise = lessonTitle + "-Exercise";
                    if (program.Contains(exercise))
                    {
                        index = program.IndexOf(exercise);
                        program.RemoveAt(index);
                    }

                    if (program.Contains(lessonTitle))
                    {
                        index = program.IndexOf(lessonTitle);
                        program.RemoveAt(index);
                    }
                }
                else if (order == "Swap")
                {
                    string lessonTitle2 = command[2];
                    string exercise1 = lessonTitle + "-Exercise";
                    string exercise2 = lessonTitle2 + "-Exercise";
                    int index2 = 0;

                    if (LessonCheck(program, lessonTitle) && LessonCheck(program, lessonTitle2))
                    {
                        index = program.IndexOf(lessonTitle);
                        index2 = program.IndexOf(lessonTitle2);
                        program.RemoveAt(index);
                        program.Insert(index, lessonTitle2);
                        program.RemoveAt(index2);
                        program.Insert(index2, lessonTitle);
                    }

                    if (program.Contains(exercise1))
                    {
                        int indexExercise = program.IndexOf(exercise1);
                        index = program.IndexOf(lessonTitle);
                        program.RemoveAt(indexExercise);
                        program.Insert(index + 1, exercise1);
                    }
                    
                    if (program.Contains(exercise2))
                    {
                        int indexExercise = program.IndexOf(exercise2);
                        index = program.IndexOf(lessonTitle2);
                        program.RemoveAt(indexExercise);
                        program.Insert(index + 1, exercise2);
                    }

                }
                else if (order == "Exercise")
                {
                    Exercise(program, lessonTitle);
                }
            }
            PrintCourses(program);
        }

        static void Exercise(List<string> program, string lessonTitle)
        {
            string exerTitle = lessonTitle + "-Exercise";
            if (LessonCheck(program, lessonTitle))
            {
                if (!(ExerciseCheck(program, lessonTitle)))
                {
                    int index = program.IndexOf(lessonTitle);
                    program.Insert(index + 1, exerTitle);
                }
            }
            else
            {
                program.Add(lessonTitle);
                program.Add(exerTitle);
            }

        }

        static bool LessonCheck(List<string> program, string lessonTitle)  //Check if coresonding lesson exists
        {
            return program.Contains(lessonTitle);
        }

        static bool ExerciseCheck(List<string> program, string lessonTitle)  //Check if coresonding exercise exists
        {
            string exerciseTitle = lessonTitle + "-Exercise";
            if (program.Contains(exerciseTitle))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintCourses(List<string> program) // print the List on console
        {
            for (int i = 0; i < program.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{program[i]}");
            }
        }
    }
}
