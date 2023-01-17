namespace _09._SoftUni_Exam_Results
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            //Judge statistics on the last Programing Fundamentals exam was not working correctly, so you
            //have the task to take all the submissions and analyze them properly.You should collect all the
            //submissions and print the final results and statistics about each language that the
            //participants submitted their solutions in.
            //You will be receiving lines in the following format: "{username}-{language}-{points}" until
            //you receive "exam finished".You should store each username and his submissions and points.
            //You can receive a command to ban a user for cheating in the following format: "{username}-
            //banned".In that case, you should remove the user from the contest, but preserve his submissions
            //in the total count of submissions for each language.
            //After receiving "exam finished" print each of the participants, ordered descending by their
            //max points, then by username, in the following format:
            //"Results:"
            //"{username} | {points}"
            //…
            //After that print each language, used in the exam, ordered descending by total submission count
            //and then by language name, in the following format:
            //"Submissions:"
            //"{language} – {submissionsCount}"
            //…
            //Input / Constraints
            //Until you receive "exam finished" you will be receiving participant submissions in the
            //following format: "{username}-{language}-{points}".
            //You can receive a ban command-> "{username}-banned"
            //The points of the participant will always be a valid integer in the range[0 - 100];
            //            Output
            //•	Print the exam results for each participant, ordered descending by max points and then by
            //username, in the following format: 
            //"Results:"
            //"{username} | {points}"
            //…
            //•	After that print each language, ordered descending by total submissions and then by language
            //name, in the following format:
            //"Submissions:"
            //"{language} – {submissionsCount}"
            //…
            //•	Allowed working time / memory: 100ms / 16MB.
            Dictionary<string, Student> students =
                    new Dictionary<string, Student>();
            Dictionary<string, int> languages = new Dictionary<string, int>();
            SettingTheScore(students, languages);

            students = students
                .OrderByDescending(s => s.Value.ScoreMax())
                .ThenBy(s => s.Key)
                .ToDictionary(s => s.Key, s => s.Value);
            languages = languages
                .OrderByDescending(l => l.Value)
                .ThenBy(l => l.Key)
                .ToDictionary(l => l.Key, l => l.Value);

            Print(students, languages);

        }

        private static void Print(Dictionary<string, Student> students, Dictionary<string, int> languages)
        {
            Console.WriteLine("Results:");
            foreach (var pupil in students)
            {
                Console.WriteLine($"{pupil.Key} | {pupil.Value.ScoreMax()}");
            }

            Console.WriteLine("Submissions:");

            foreach (var lang in languages)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }

        private static void SettingTheScore(Dictionary<string, Student> students, Dictionary<string, int> languages)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "exam finished")
            {
                string[] input = inputLine.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                if (input.Length == 3)
                {
                    string language = input[1];
                    int score = int.Parse(input[2]);
                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 0);
                    }
                    languages[language]++;

                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, new Student(name));
                    }
                    if (!students[name].ScoreInLanguages.ContainsKey(language))
                    {
                        students[name].ScoreInLanguages.Add(language, 0);
                    }
                    students[name].ScoreInLanguages[language] = score;
                }
                else if (input.Length == 2)
                {
                    if (students.ContainsKey(name))
                    {
                        students.Remove(name);
                    }
                }
            }
        }
    }

    public class Student
    {
        public Student(string name)
        {
            Name = name;
            ScoreInLanguages = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> ScoreInLanguages { get; set; }

        public void AddLanguage(string language, int score)
        {
            if (ScoreInLanguages.ContainsKey(language))
            {
                ScoreInLanguages.Add(language, 0);
            }

            ScoreInLanguages[language] += score;
        }

        public int ScoreMax()
        {
            int max = int.MinValue;
            foreach (var item in ScoreInLanguages)
            {
                if (max < item.Value)
                {
                    max = item.Value;
                }
            }
            return max;
        }
    }
}
