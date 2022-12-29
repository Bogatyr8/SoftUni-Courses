using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
//Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy".Use named capturing groups in your
//regular expression.
//Compose the Regular Expression
//Every valid date has the following characteristics:
//•	Always starts with two digits, followed by a separator.
//•	After that, it has one uppercase and two lowercase letters(e.g.Jan, Mar).
//•	After that, it has a separator and exactly 4 digits(for the year).
//•	The separator could be either of three things: a period('. '), a hyphen('-') or a forward - slash('/').
//•	The separator needs to be the same for the whole date(e.g. 13.03.2016 is valid, 13.03 / 2016 is NOT).Use a group
//backreference to check for this.
            string regex = @"(?<day>\d{2})(/| |.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            string dateStrings = Console.ReadLine();

            MatchCollection dates = Regex.Matches(dateStrings, regex);

            foreach (Match item in dates)
            {
                string day = item.Groups["day"].Value;
                string month = item.Groups["month"].Value;
                string year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
