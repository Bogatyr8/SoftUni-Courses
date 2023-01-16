namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that ranks candidate-interns, depending on the points from the interview
            //tasks and their exam results in SoftUni.You will receive some lines of input in the format
            //"{contest}:{password for contest}" until you receive "end of contests".
            //Save that data because you will need it later. After that you will receive another type of
            //inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive
            //"end of submissions".Here is what you need to do:
            //•	Check if the contest is valid(if you received it in the first type of input)
            //•	Check if the password is correct for the given contest
            //•	Save the user with the contest they take part in (a user can take part in many contests)
            //and the points the user has in the given contest.If you receive the same contest and the same
            //user, update the points only if the new ones are more than the older ones.
            //At the end you have to print the info for the user with the most points in the format:
            //"Best candidate is {user} with total {total points} points.".After that print all students
            //ordered by their names.For each user, print each contest with the points in descending order
            //in the following format:
            //"{user1 name}
            //#  {contest1} -> {points}
            //#  {contest2} -> {points}
            //{ user2 name}
            //…"
            //Input
            //•	You will be receiving strings in the formats described above, until the appropriate
            //commands, also described above, are given.
            //Output
            //•	On the first line print, the best user in the format described above. 
            //•	On the next lines print all students ordered as mentioned above in format.
            //Constraints
            //•	There will be no case with two equal contests.
            //•	The strings may contain any ASCII character except(:, =, >).
            //•	The numbers will be in the range[0 - 10000].
            //•	The second input is always valid.
            //•	There will be no case with 2 or more users with the same total points.
            Dictionary<string, string> courses = new Dictionary<string, string>();

            SetTheContest(courses);

            Dictionary<string, Student> students = new Dictionary<string, Student>();

            EvaluateStudents(courses, students);

            students = students
                .OrderBy(s => s.Value.Name)
                .ToDictionary(s => s.Key, s => s.Value);

            string bestStudent = string.Empty;
            int bestScore = 0;

            EvaluareTheBestStudent(students, ref bestStudent, ref bestScore);

            Console.WriteLine($"Best candidate is {bestStudent} with total {bestScore} points.");
            Console.WriteLine("Ranking:");
            foreach (var pupil in students)
            {
                Console.WriteLine(pupil.Key);
                foreach (var course in pupil.Value.PersonalCources.OrderByDescending(c => c.Value).ToDictionary(s => s.Key, s => s.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }

        private static void EvaluareTheBestStudent(Dictionary<string, Student> students, ref string bestStudent, ref int bestScore)
        {
            foreach (var pupil in students)
            {
                int score = pupil.Value.ScoreSum();
                if (score > bestScore)
                {
                    bestScore = score;
                    bestStudent = pupil.Key;
                }
            }
        }

        private static void EvaluateStudents(Dictionary<string, string> courses, Dictionary<string, Student> students)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of submissions")
            {
                string[] input = inputLine.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = input[0];
                string password = input[1];
                string studentName = input[2];
                int points = int.Parse(input[3]);
                if (courses.ContainsKey(contest) && (courses[contest] == password))
                {
                    if (!students.ContainsKey(studentName))
                    {
                        students.Add(studentName, new Student(studentName));
                    }
                    if (!students[studentName].PersonalCources.ContainsKey(contest))
                    {
                        students[studentName].PersonalCources.Add(contest, points);
                    }
                    if (students[studentName].PersonalCources[contest] < points)
                    {
                        students[studentName].PersonalCources[contest] = points;
                    }
                }
            }
        }

        private static void SetTheContest(Dictionary<string, string> courses)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of contests")
            {
                string[] input = inputLine.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = input[0];
                string password = input[1];
                if (!courses.ContainsKey(contest))
                {
                    courses.Add(contest, password);
                }
            }
        }
    }

    public class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.PersonalCources = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> PersonalCources { get; set; }

        public int ScoreSum()
        {
            int sum = 0;
            foreach (var item in PersonalCources)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
