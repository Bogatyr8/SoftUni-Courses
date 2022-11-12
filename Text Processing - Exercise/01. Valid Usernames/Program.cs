using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that reads user names on a single line(joined by ", ") and prints all valid usernames.

//A valid username

//· has length between 3 and 16 characters

//· contains only letters, numbers, hyphens and underscores
            string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                if (item.Length < 3 || item.Length > 16)
                {
                    continue;
                }
                bool doesItHaveLegalChars = true;
                for (int i = 0; i < item.Length; i++)
                {
                    if (!(item[i] >= 65 && item[i] <= 90 || item[i] >= 97 && item[i] <= 122 || item[i] >= 48 && item[i] <= 57 || item[i] == '-' || item[i] == '_'))
                    {
                        doesItHaveLegalChars = false;
                        continue;
                    }
                }
                if (doesItHaveLegalChars)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
